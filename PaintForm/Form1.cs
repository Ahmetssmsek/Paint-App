using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintForm
{
    public partial class Form1 : Form
    {
        
        
        bool isEraserMode = false; 


        public Form1()
        {
            InitializeComponent();

            loadPictureBox();

            
            selectedShapeButton = PenButton;
            selectedShapeButton.BackColor = Color.Red;



            undoStack = new Stack<Bitmap>();
            redoStack = new Stack<Bitmap>();
        }

        Bitmap paintImage;
        Graphics paintGraphics;
        Stack<Bitmap> undoStack;
        Stack<Bitmap> redoStack;

        private void loadPictureBox()
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            paintImage = new Bitmap(width, height);

            paintGraphics = Graphics.FromImage(paintImage);

            paintGraphics.FillRectangle(Brushes.White, 0, 0, width, height);
            
            pictureBox1.Image = paintImage;

            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
        }

        Point lastPoint;
        bool isMouseDown = false;

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }
                
        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (isEraserMode)
                {
                    EraseInCanvas(e.Location);
                }
                else if (selectedShapeButton.Text == "Pen")
                {
                    DrawLineInCanvas(e.Location);
                }
                else
                {
                    DrawShapeInWorkingImage(e.Location);
                }
            }
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            if (selectedShapeButton.Text != "Pen")
            {
                
                DrawShapeInWorkingImage(e.Location);

                paintImage = new Bitmap(workingImage);

               
                paintGraphics = Graphics.FromImage(paintImage);

                pictureBox1.Image = paintImage;
            }

       
        }
        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                Bitmap redoImage = redoStack.Pop();
                paintImage = redoImage;

                paintGraphics = Graphics.FromImage(paintImage);

                pictureBox1.Image = paintImage;
                pictureBox1.Refresh();
            }
        }
        private void DrawLineInCanvas(Point currentPoint)
        {
           
            Pen pen = new Pen(colorPicker.Color, trackBar1.Value);

            paintGraphics.DrawLine(pen, lastPoint, currentPoint);

            lastPoint = currentPoint;

            pictureBox1.Refresh();
        }
        
        ColorDialog colorPicker = new ColorDialog();

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
        }
        
        Bitmap workingImage;
        Graphics workingGraphics;

       
        private void DrawShapeInWorkingImage(Point currentPoint)
        {
            Pen pen = new Pen(colorPicker.Color, trackBar1.Value);

            workingImage = new Bitmap(paintImage);
            workingGraphics = Graphics.FromImage(workingImage);

            int startPointX = lastPoint.X < currentPoint.X ? lastPoint.X : currentPoint.X;
            int startPointY = lastPoint.Y < currentPoint.Y ? lastPoint.Y : currentPoint.Y;

            int shapeWidth = (lastPoint.X > currentPoint.X ? lastPoint.X : currentPoint.X) - startPointX;
            int shapeHeight = (lastPoint.Y > currentPoint.Y ? lastPoint.Y : currentPoint.Y) - startPointY;

            switch (selectedShapeButton.Text)
            {
                case "Rectangle":
                    
                    if (!FillColorCheckBox.Checked)
                    {
                       
                        workingGraphics.DrawRectangle(pen, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    else
                    {
                      
                        workingGraphics.FillRectangle(pen.Brush, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    break;

                case "Circle":
                    if (!FillColorCheckBox.Checked)
                    {
                        workingGraphics.DrawEllipse(pen, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    else
                    {
                        workingGraphics.FillEllipse(pen.Brush, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    break;

                case "Triangle":
                    Point point1 = new Point() { X = startPointX, Y = startPointY + shapeHeight };
                    Point point2 = new Point() { X = startPointX + (shapeWidth / 2), Y = startPointY };
                    Point point3 = new Point() { X = startPointX + shapeWidth, Y = startPointY + shapeHeight };

                    if (!FillColorCheckBox.Checked)
                    {
                        workingGraphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    }
                    else
                    {
                        workingGraphics.FillPolygon(pen.Brush, new Point[] { point1, point2, point3 });
                    }
                    break;

                case "Line":
                    workingGraphics.DrawLine(pen, lastPoint, currentPoint);
                    break;
            }

           
            if (isMouseDown && selectedShapeButton.Text != "Line") 
            {
               
                Pen outLinePen = new Pen(Color.Black);
                outLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                workingGraphics.DrawRectangle(outLinePen, startPointX, startPointY, shapeWidth, shapeHeight);
            }

            pictureBox1.Image = workingImage;
        }
        

        Button selectedShapeButton;

        private void PenButtond_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;

            Button clickedButton = sender as Button;
            clickedButton.BackColor = Color.Red;

            selectedShapeButton = clickedButton;
        }
        private void EraseInCanvas(Point currentPoint)
        {
          
            Brush brush = new SolidBrush(Color.White);

           
            int eraserSize = trackBar1.Value;

           
            Rectangle eraserRect = new Rectangle(
                currentPoint.X - (eraserSize / 2),
                currentPoint.Y - (eraserSize / 2),
                eraserSize,
                eraserSize);

         
            paintGraphics.FillEllipse(brush, eraserRect);

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        
  
  

        private void RedoButton_Click_1(object sender, EventArgs e)
        {
         
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                saveDialog.Title = "Save Image";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;
                    ImageFormat format;

                    switch (Path.GetExtension(filePath).ToLower())
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        default:
                            MessageBox.Show("Unsupported file format.");
                            return;
                    }

                  
                    try
                    {
                        pictureBox1.Image.Save(filePath, format);
                        MessageBox.Show("Image saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message);
                    }
                }
            }
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            Button clickedButton = sender as Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;

           
            Cursor = Cursors.Cross;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            {

                paintImage = new Bitmap(paintImage.Width, paintImage.Height);
                paintGraphics = Graphics.FromImage(paintImage);
                undoStack.Clear();
                redoStack.Clear();
                pictureBox1.Image = paintImage;
                pictureBox1.Refresh();
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(paintImage)); 

                Bitmap previousImage = undoStack.Pop();
                paintImage = new Bitmap(previousImage);

                paintGraphics = Graphics.FromImage(paintImage);

                pictureBox1.Image = paintImage;
                pictureBox1.Refresh();
            }
        }
    }
}

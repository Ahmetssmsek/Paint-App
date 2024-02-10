namespace PaintForm
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.FillColorCheckBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
          


            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 501);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
           


            this.ColorPickerButton.Location = new System.Drawing.Point(729, 12);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(92, 90);
            this.ColorPickerButton.TabIndex = 1;
            this.ColorPickerButton.Text = "Color Picker";
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
          



            this.PenButton.Location = new System.Drawing.Point(729, 169);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(92, 45);
            this.PenButton.TabIndex = 2;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButtond_Click);
          



            this.trackBar1.Location = new System.Drawing.Point(729, 108);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(92, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
          


            this.button3.Location = new System.Drawing.Point(865, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
         


            this.FillColorCheckBox.AutoSize = true;
            this.FillColorCheckBox.Location = new System.Drawing.Point(729, 343);
            this.FillColorCheckBox.Name = "FillColorCheckBox";
            this.FillColorCheckBox.Size = new System.Drawing.Size(65, 17);
            this.FillColorCheckBox.TabIndex = 4;
            this.FillColorCheckBox.Text = "Fill Color";
            this.FillColorCheckBox.UseVisualStyleBackColor = true;
          



            this.button4.Location = new System.Drawing.Point(729, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Rectangle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PenButtond_Click);
         



            this.button5.Location = new System.Drawing.Point(729, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "Line";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PenButtond_Click);
         


            this.button6.Location = new System.Drawing.Point(729, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "Circle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PenButtond_Click);
           


            this.button7.Location = new System.Drawing.Point(729, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "Triangle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PenButtond_Click);
          


            this.SaveButton.Location = new System.Drawing.Point(730, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
           


            this.EraserButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.EraserButton.Location = new System.Drawing.Point(729, 249);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(88, 23);
            this.EraserButton.TabIndex = 8;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
         


            this.ClearButton.Location = new System.Drawing.Point(730, 220);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
        



            this.UndoButton.Location = new System.Drawing.Point(730, 318);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(87, 19);
            this.UndoButton.TabIndex = 10;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
           




            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 527);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FillColorCheckBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.ColorPickerButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ColorPickerButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox FillColorCheckBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UndoButton;
    }
}


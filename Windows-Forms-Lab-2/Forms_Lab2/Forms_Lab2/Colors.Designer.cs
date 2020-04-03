using System.ComponentModel;

namespace Forms_Lab2
{
    partial class Colors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.button_colors_ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picResultColor)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(119, 35);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(224, 20);
            this.Scroll_Red.TabIndex = 0;
            this.Scroll_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Red_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(119, 66);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(224, 20);
            this.Scroll_Green.TabIndex = 1;
            this.Scroll_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Green_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(119, 96);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(224, 20);
            this.Scroll_Blue.TabIndex = 2;
            this.Scroll_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(50, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Green";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(364, 34);
            this.numeric_Red.Maximum = new decimal(new int[] {255, 0, 0, 0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(45, 21);
            this.numeric_Red.TabIndex = 6;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.numeric_Red_ValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(364, 65);
            this.numeric_Green.Maximum = new decimal(new int[] {255, 0, 0, 0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(45, 21);
            this.numeric_Green.TabIndex = 7;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.numeric_Green_ValueChanged);
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(364, 95);
            this.numeric_Blue.Maximum = new decimal(new int[] {255, 0, 0, 0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(45, 21);
            this.numeric_Blue.TabIndex = 8;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.numeric_Blue_ValueChanged);
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(425, 33);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(85, 83);
            this.picResultColor.TabIndex = 9;
            this.picResultColor.TabStop = false;
            // 
            // button_colors_ok
            // 
            this.button_colors_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_colors_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_colors_ok.Location = new System.Drawing.Point(50, 158);
            this.button_colors_ok.Name = "button_colors_ok";
            this.button_colors_ok.Size = new System.Drawing.Size(85, 29);
            this.button_colors_ok.TabIndex = 10;
            this.button_colors_ok.Text = "Ok";
            this.button_colors_ok.UseVisualStyleBackColor = true;
            this.button_colors_ok.Click += new System.EventHandler(this.button_colors_ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(157, 158);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 29);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Other colors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOtherColor);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 243);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button_colors_ok);
            this.Controls.Add(this.picResultColor);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numeric_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picResultColor)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button_colors_ok;
    }
}
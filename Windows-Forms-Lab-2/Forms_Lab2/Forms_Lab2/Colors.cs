using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_Lab2
{
    public partial class Colors : Form
    {
        private Color colorResault;
        private List<int> colorsHistory; // история использованных цветов

        public Colors(Color color, List<int> colorsHist)
        {
            InitializeComponent();

            Scroll_Red.Tag = numeric_Red;
            Scroll_Green.Tag = numeric_Green;
            Scroll_Blue.Tag = numeric_Blue;

            numeric_Red.Tag = Scroll_Red;
            numeric_Green.Tag = Scroll_Green;
            numeric_Blue.Tag = Scroll_Blue;

            numeric_Red.Value = color.R;
            numeric_Green.Value = color.G;
            numeric_Blue.Value = color.B;

            picResultColor.BackColor = color;

            colorsHistory = colorsHist;
        }

        private void Scroll_Red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar) sender;
            NumericUpDown numericUpDown = (NumericUpDown) scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void Scroll_Green_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar) sender;
            NumericUpDown numericUpDown = (NumericUpDown) scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void Scroll_Blue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar) sender;
            NumericUpDown numericUpDown = (NumericUpDown) scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

            UpdateColor();
        }

        private void numeric_Red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            ScrollBar scrollBar = (ScrollBar) numericUpDown.Tag;
            scrollBar.Value = (int) numericUpDown.Value;

            UpdateColor();
        }

        private void numeric_Green_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            ScrollBar scrollBar = (ScrollBar) numericUpDown.Tag;
            scrollBar.Value = (int) numericUpDown.Value;

            UpdateColor();
        }

        private void numeric_Blue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            ScrollBar scrollBar = (ScrollBar) numericUpDown.Tag;
            scrollBar.Value = (int) numericUpDown.Value;

            UpdateColor();
        }

        private void UpdateColor()
        {
            colorResault = Color.FromArgb(Scroll_Red.Value, Scroll_Green.Value, Scroll_Blue.Value);
            picResultColor.BackColor = colorResault;
        }
        
        private int ColorToInt(Color color)
        {
            byte[] result = new byte[4];
            result[0] = color.R;
            result[1] = color.G;
            result[2] = color.B;
            return BitConverter.ToInt32(result, 0);
        }

        private void buttonOtherColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.SolidColorOnly = false;
            
            if (colorsHistory.Count != 0)
            {
                colorsHistory.Reverse();
                colorDialog.CustomColors = colorsHistory.ToArray();
            }


            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Scroll_Red.Value = colorDialog.Color.R;
                Scroll_Green.Value = colorDialog.Color.G;
                Scroll_Blue.Value = colorDialog.Color.B;

                numeric_Red.Value = colorDialog.Color.R;
                numeric_Green.Value = colorDialog.Color.G;
                numeric_Blue.Value = colorDialog.Color.B;

                colorResault = colorDialog.Color;
                
                
                // Если список выбранных цветов не пустой, указать их в кастомном блоке
                // при заполнении доп блока цветов, удалять тот что был в самом начале
                if (colorsHistory.Count == 16)
                {
                    colorsHistory.RemoveAt(0);
                }
                colorsHistory.Add(ColorToInt(colorDialog.Color));

                UpdateColor();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_colors_ok_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.currentPen.Color = colorResault;
                main.customColorsHistory = colorsHistory;
                main.picCurrentColorUpdate();
                this.Close();
            }
        }
    }
}
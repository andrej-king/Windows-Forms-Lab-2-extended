using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab2
{
    public partial class Form1 : Form
    {
        private bool drawing;
        public int historyCounter; // счетчик истории

        private GraphicsPath currentPath;
        private Point oldLocation;
        public Pen currentPen;
        private Color historyColor; // сохранение текущего цвета перед использование ластика
        private List<Image> History; // список для истории


        public List<int> customColorsHistory; // история использованных цветов

        public Form1()
        {
            InitializeComponent();
            drawing = false; // переменная отвечает за рисование
            currentPen = new Pen(Color.Black);
            currentPen.Width = trackBarPen.Value;
            labelFontSizeNum.Text = trackBarPen.Value.ToString();
            History = new List<Image>(); // инициализация списка для истории

            customColorsHistory = new List<int>();

            picDrawingSurface.Image = null;

            picCurrentColor.BackColor = currentPen.Color;
        }

        private void CreateNewFile(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null
            ) // если пользователь захотел создать новый файл, но что-то уже нарисовано
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка??",
                    "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes:
                        SaveFileAs(sender, e);
                        break;
                    case DialogResult.Cancel: return;
                }
            }

            // Очистка ненужной истории
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;
            picDrawingSurface.BackColor = Color.White;
            picDrawingSurface.BorderStyle = BorderStyle.Fixed3D;
            History.Add(new Bitmap(picDrawingSurface.Image));

            try
            {
                picDrawingSurface.Cursor = Cursors.Cross;
            }
            catch
            {
                picDrawingSurface.Cursor = Cursors.Default;
            }
        }

        private void SaveFileAs(object sende, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }
            else
            {
                SaveFileDialog SaveDlg = new SaveFileDialog();
                SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
                SaveDlg.Title = "Save an Image File";
                SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png
                SaveDlg.ShowDialog();


                if (SaveDlg.FileName != "") // если введено не пустое имя
                {
                    System.IO.FileStream fs = (System.IO.FileStream) SaveDlg.OpenFile();

                    switch (SaveDlg.FilterIndex)
                    {
                        case 1:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                            break;
                        case 3:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                            break;
                        case 4:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                            break;
                    }

                    fs.Close();
                }
            }
        }


        private void FileOpen(object sender, EventArgs e)
        {
            CreateNewFile(sender, e);

            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; // По умолчанию выбрано первое расширение *.jpg

            // Когда пользователь укажет нужный путь картинки, ее нужно загрузить в PictureBox
            if (OP.ShowDialog() != DialogResult.Cancel) picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
            picDrawingSurface.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void EndProgramm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickUndo(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else
            {
                MessageBox.Show("История пуста");
            }
        }

        private void ClickRedo(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else
            {
                MessageBox.Show("История пуста");
            }
        }

        private void PenStyleSolid(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;

            solidStyleMenu.Checked = true;
            dotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;
        }

        private void PenStyleDot(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;

            dotStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
            solidStyleMenu.Checked = false;
        }

        private void PenStyleDashDot(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDot;

            dashDotDotStyleMenu.Checked = true;
            dotStyleMenu.Checked = false;
            solidStyleMenu.Checked = false;
        }

        private void ClickHelpMenu(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Paint v1.0\nCreate by Pedchenko Andrii");
        }

        public void picCurrentColorUpdate() // обновление picture box с текущим цветом пера
        {
            picCurrentColor.BackColor = currentPen.Color;
        }
        

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                historyColor = currentPen.Color;
            }

            if (e.Button == MouseButtons.Right)
            {
                currentPen.Color = Color.White;
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
        }


        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            // Очистка ненужной истории
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (historyCounter - 1 == 10) History.RemoveAt(0);

            drawing = false;
            currentPen.Color = historyColor;
            try
            {
                currentPath.Dispose();
            }
            catch
            {
            }

            ;
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();

            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }

        private void trackBarPen_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBarPen.Value;
            labelFontSizeNum.Text = trackBarPen.Value.ToString();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Form color_form = new Colors(currentPen.Color, customColorsHistory);
            color_form.Owner = this;
            color_form.ShowDialog();
        }
    }
}
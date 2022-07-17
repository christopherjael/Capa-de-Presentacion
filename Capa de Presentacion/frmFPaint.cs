using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Capa_de_Presentacion
{
    public partial class frmFPaint : Form
    {

        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        int DefaultWidthPen = 8;
        Color lastColorPick = Color.Black;
        
        public frmFPaint()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, DefaultWidthPen);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void SetPenColor(Color c)
        {
            pen.Color = c;
            pnlCurrentColor.BackColor = c;
            lastColorPick = c;
        }

        private void SetPenWidth(float w)
        {
            pen.Width = w;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlCurrentColor.BackColor = Color.White;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x,y),e.Location);
                x = e.X;
                y = e.Y;
                g.Flush();
                g.Save();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false; 
            x = e.X; 
            y = e.Y;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void cBlack_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Black);
        }

        private void cGray_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Gray);
        }

        private void cRed_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Red);
        }

        private void cOrange_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Orange);
        }

        private void cYellow_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Yellow);
        }

        private void cWhite_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.White);
        }

        private void cGreen_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Green);
        }

        private void cCian_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Cyan);
        }

        private void cBlue_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Blue);
        }

        private void cViolet_Click(object sender, EventArgs e)
        {
            SetPenColor(Color.Violet);
        }

        private void btnColorCustom_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            
            if( colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetPenColor(colorDialog.Color);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            SetPenWidth(Convert.ToInt64(selectedItem));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetPenColor(lastColorPick);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pen.Color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                    bmp.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}

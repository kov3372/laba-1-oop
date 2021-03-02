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

namespace lab1
{
    public partial class завдання_3 : Form
    {
        public завдання_3()
        {
            InitializeComponent();

            this.pictureBox1.Image = this.Draw();
         
        }

        private void завдання_3_Load(object sender, EventArgs e)
        {

           

        }

        public Bitmap Draw()
        {
            var bitmap = new Bitmap(400, 200, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillRectangle(new SolidBrush(Color.Tomato), 15, 10, 150, 200);

            
            return bitmap;
        }

        delegate void MoveonMouse();


    }
}

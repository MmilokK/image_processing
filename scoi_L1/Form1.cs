using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoi_L1
{
    public partial class Form1 : Form
    {
        Bitmap img1, img2, img_out;
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen p = new Pen(Color.Black, 3);
            Rectangle rect1 = new Rectangle(1026, 12, 255, 255);
            e.Graphics.DrawRectangle(p, rect1);
            rect1.Y = 273;
            e.Graphics.DrawRectangle(p, rect1);
            rect1.X = 55; 
            rect1.Y = 12;
            rect1.Width = 934;
            rect1.Height = 516;
            e.Graphics.DrawRectangle(p, rect1);
            p.Dispose();
            e.Graphics.Dispose();

        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "RGB";
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        

        private void addPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Load(openFileDialog1.FileName);
                label1.Text = "";
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Load(openFileDialog1.FileName);
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileFialog = new SaveFileDialog();
            saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileFialog.Filter = "Картинки (jpg, png, bmp, gif) |.jpg;.png;.bmp;.gif|All files (.)|.";
            saveFileFialog.RestoreDirectory = true;

            if (saveFileFialog.ShowDialog() == DialogResult.OK)
            {
                if (img_out != null)
                {
                    img_out.Save(saveFileFialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var w = Math.Max(img1.Width, img2.Width);
            var h = Math.Max(img1.Height, img2.Height);

            img_out = new Bitmap(w, h);

            using (var gr = Graphics.FromImage(img_out)) 
            {              

                
                var img11 = new Bitmap(img1,w, h);
                var img22 = new Bitmap(img2, w, h);

                for (int i = 0; i < h; ++i)
                {
                    for (int j = 0; j < w; ++j)
                    {
                        
                        var pix1  = img11.GetPixel(j, i);
                        var pix2 = img22.GetPixel(j, i);

                        int r = (pix1.R + pix2.R) / 2;
                        int g = (pix1.G + pix2.G) / 2;
                        int b = (pix1.B + pix2.B) / 2;

                        var pix = Color.FromArgb(r, g, b);
                        img_out.SetPixel(j, i, pix);
                    }
                }
                
                img_out.Save("..\\..\\out.jpg");
                label3.Text = "";
                pictureBox3.Image = img_out;
                img1.Dispose();
                img2.Dispose();
                img11.Dispose();
                img22.Dispose();

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //img_out = new Bitmap("..\\..\\out.jpg");
            int h = 0;
            var w = 0;
            if (img_out!=null)
            {
                h = img_out.Height;
                w = img_out.Width;
                var newImg_out = new Bitmap(w, h);

            switch (comboBox1.SelectedItem)
            {
                case "RGB":
                    {
                        pictureBox3.Image = img_out;
                        break;
                    }
                case "R":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int r = pix.R;

                                pix = Color.FromArgb(r, 0, 0);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                case "G":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int g = pix.G;
                                pix = Color.FromArgb(0, g, 0);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                case "B":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int b = pix.B;
                                pix = Color.FromArgb(0, 0, b);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                case "RG":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int r = pix.R;
                                int g = pix.G;
                                pix = Color.FromArgb(r, g, 0);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                case "RB":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int r = pix.R;
                                int b = pix.B;
                                pix = Color.FromArgb(r, 0, b);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                case "GB":
                    {
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = img_out.GetPixel(j, i);
                                int g = pix.G;
                                int b = pix.B;
                                pix = Color.FromArgb(0, g, b);
                                newImg_out.SetPixel(j, i, pix);
                            }
                        }
                        pictureBox3.Image = newImg_out;
                        break;
                    }
                default: break;
            }
            }

        }
    }
}

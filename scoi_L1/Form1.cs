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
        int w, h;
        
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
            channalBox.SelectedItem = "RGB";
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
            w = Math.Max(img1.Width, img2.Width);
            h = Math.Max(img1.Height, img2.Height);
            img1 = new Bitmap(img1, w, h);
            img2 = new Bitmap(img2, w, h);
        }

        private void buttonSave_Click(object sender, EventArgs e)
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

        private void buttonFunction_Click(object sender, EventArgs e)
        {
            if (FunctionBox.SelectedItem != "Маска")
                img_out = new Bitmap(w, h);
            else
                img_out = new Bitmap("..\\..\\out.jpg");
            using (var gr = Graphics.FromImage(img_out)) 
            {
                
                for (int i = 0; i < h; ++i)
                {
                    for (int j = 0; j < w; ++j)
                    {
                        var pix1  = img1.GetPixel(j, i);
                        var pix2 = img2.GetPixel(j, i);
                        var pix = new Color();

                        if (FunctionBox.SelectedItem != "Маска")
                            pix = Function(pix, pix1, pix2);
                        else
                        {
                            pix = img_out.GetPixel(j, i);
                            pix = Mask_Pixel(pix, j, i);

                        }
                        pix = Channel(pix, pix.R, pix.G, pix.B);
                        img_out.SetPixel(j, i, pix);
                    }
                }
                if (channalBox.SelectedItem == "RGB"&&FunctionBox.SelectedItem!="Маска")
                    img_out.Save("..\\..\\out.jpg");
                label3.Text = "";
                pictureBox3.Image = img_out;
                
            }
        }
        private void channelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (img_out != null)
            {
                img_out = new Bitmap("..\\..\\out.jpg");
                h = img_out.Height;
                w = img_out.Width;
                //var newImg_out = new Bitmap(w, h);

                for (int i = 0; i < h; ++i)
                {
                    for (int j = 0; j < w; ++j)
                    {
                        var pix = img_out.GetPixel(j, i);
                        int r = pix.R;
                        int g = pix.G;
                        int b = pix.B;
                        if (channalBox.SelectedItem == "RGB")
                        {

                            var pix1 = img1.GetPixel(j, i);
                            var pix2 = img2.GetPixel(j, i);
                            pix = Function(pix, pix1, pix2);
                            img_out.SetPixel(j, i, pix);


                        }
                        
                        pix = Channel(pix, r, g, b);
                        
                        img_out.SetPixel(j, i, pix);
                        pictureBox3.Image = img_out;
                    }
                }
            }

        }

        private Color Channel(Color pix, int r, int g, int b)
        {
            switch (channalBox.SelectedItem)
            {
                case "RGB":
                    {
                        break;
                    }
                case "R":
                    {
                        pix = Color.FromArgb(r, 0, 0);
                        break;
                    }
                case "G":
                    {
                        pix = Color.FromArgb(0, g, 0);
                        break;
                    }
                case "B":
                    {
                        pix = Color.FromArgb(0, 0, b);
                        break;
                    }
                case "RG":
                    {
                        pix = Color.FromArgb(r, g, 0);
                        break;
                    }
                case "RB":
                    {
                        pix = Color.FromArgb(r, 0, b);
                        break;
                    }
                case "GB":
                    {
                        pix = Color.FromArgb(0, g, b);
                        break;
                    }
                default: break;
            }
            return pix;
        }
        private Color Function(Color pix, Color pix1, Color pix2)
        {
            switch (FunctionBox.SelectedItem)
            {
                case "Сумма":
                    pix = Summ_Pixel(pix1, pix2);
                    break;
                case "Среднее арифметическое":
                    pix = Average_Pixel(pix1, pix2);
                    break;
                case "Произведение":
                    pix = Product_Pixel(pix1, pix2);
                    break;
                case "Минимум":
                    pix = Min_Pixel(pix1, pix2);
                    break;
                case "Максимум":
                    pix = Max_Pixel(pix1, pix2);
                    break;
                case "Маска":
                    //pix = Mask_Pixel(img_out.GetPixel(j, i));
                    break;
                default: break;
            }
            return pix;
        }
        private Color Summ_Pixel(Color pix1, Color pix2)
        {
            int r = Clamp(pix1.R + pix2.R, 0, 255);
            int g = Clamp(pix1.G + pix2.G, 0, 255);
            int b = Clamp(pix1.B + pix2.B, 0, 255);
            var pix = Color.FromArgb(r, g, b);
            return pix;
        }
        private Color Average_Pixel(Color pix1, Color pix2)
        {
            int r = (pix1.R + pix2.R) / 2;
            int g = (pix1.G + pix2.G) / 2;
            int b = (pix1.B + pix2.B) / 2;
            var pix = Color.FromArgb(r, g, b);
            return pix;
        }
        private Color Product_Pixel(Color pix1, Color pix2)
        {
            int r = pix1.R * pix2.R / 255;
            int g = pix1.G * pix2.G / 255;
            int b = pix1.B * pix2.B / 255;
            var pix = Color.FromArgb(r, g, b);
            return pix;
        }
        private Color Min_Pixel(Color pix1, Color pix2)
        {
            int r = Math.Min(pix1.R, pix2.R);
            int g = Math.Min(pix1.G, pix2.G);
            int b = Math.Min(pix1.B, pix2.B);
            var pix = Color.FromArgb(r, g, b);
            return pix;
        }

        private void FunctionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionBox.SelectedItem == "Маска")
            {
                MaskBox.Visible = true;
            }
            else
                MaskBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                img1.Dispose();
                img2.Dispose();
                img_out.Dispose();
            }
        }

        private void MaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Color Max_Pixel(Color pix1, Color pix2)
        {
            int r = Math.Max(pix1.R, pix2.R);
            int g = Math.Max(pix1.G, pix2.G);
            int b = Math.Max(pix1.B, pix2.B);
            var pix = Color.FromArgb(r, g, b);
            return pix;
        }
        private Color Mask_Pixel(Color pix, int x, int y)
        {
            switch (MaskBox.SelectedItem)
            {
                case "круг":
                    pix = Print_Circle(pix, x, y);
                    break;
            }



            return pix;
        }

        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }
        private Color Print_Circle(Color pix, int x, int y)
        {
            if (w <= h)
            {
                if ((x - w / 2) * (x - w / 2) + (y - h / 2) * (y - h / 2) >= (w / 2) * (w / 2))
                    pix = Color.FromArgb(1, 1, 1);

            }
            else if (w > h)
            {
                if ((x - w / 2) * (x - w / 2) + (y - h / 2) * (y - h / 2) >= (h / 2) * (h / 2))
                    pix = Color.FromArgb(1, 1, 1);
            }
            return pix;
        }
    }
}

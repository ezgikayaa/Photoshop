using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazLab1
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        Bitmap image = new Bitmap(900, 900);
        
        
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png*.bmp;";
            dosya.Title = "Dosya Seç";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }



            a = 0;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            image = bmp;
          
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                a = 1;
                int i, j;
                Color renk;//Color sınıfından bir renk nesne tanımlıyoruz.
                Bitmap bmp = new Bitmap(pictureBox1.Image);


                for (i = 0; i <= bmp.Width - 1; i++)//dikey olarak görüntümüzü tarıyoruz.
                {
                    for (j = 0; j <= bmp.Height - 1; j++)//yatay olarak görüntümüzü tarıyoruz.
                    {
                        renk = bmp.GetPixel(i, j);
                        renk = Color.FromArgb((byte)((renk.R + renk.G + renk.B) / 3), (byte)((renk.R + renk.G + renk.B) / 3), (byte)((renk.R + renk.G + renk.B) / 3));
                        bmp.SetPixel(i, j, renk);

                    }
                }
                pictureBox1.Image = bmp;

            }
        }

        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(255 - bmp.GetPixel(i, j).R, 255 - bmp.GetPixel(i, j).G, 255 - bmp.GetPixel(i, j).B));
                    }
                }
                pictureBox1.Image = bmp;
            }
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap yatay = YatayAyna(image);
            pictureBox1.Image = yatay;
        }
        public Bitmap YatayAyna(Bitmap bmp)
        {

            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(i, b.Height - j - 1, bmp.GetPixel(i, j));
                }
            }
            return b;
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap dikey = DikeyAyna(image);
            pictureBox1.Image = dikey;

        }

        public Bitmap DikeyAyna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - i - 1, j, bmp.GetPixel(i, j));
                }
            }
            return b;

        }

        private void sağa90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap sag = SagaDondur(image);
            pictureBox1.Image = sag;
        }
        public Bitmap SagaDondur(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - j - 1, i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }

        private void sola90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap sol = SolaDondur(image);
            pictureBox1.Image = sol;
        }
        public Bitmap SolaDondur(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }

        public static Form2 f2 = new Form2();
        public static Form1 f1 = new Form1();

        private void boyutlandırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            f2.Show(); 
            
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            pictureBox1.Image = image;
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(0, image.GetPixel(i, j).G, 0));
                    }
                }
                pictureBox1.Image = bmp;
            }
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(0, 0, image.GetPixel(i, j).B));
                    }
                }
                pictureBox1.Image = bmp;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(image.GetPixel(i, j).R, 0, 0));
                    }
                }
                pictureBox1.Image = bmp;
            }

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int[] kirmizi = new int[256];
                int[] yesil = new int[256];
                int[] mavi = new int[256];

                for (int i = 1; i < bmp.Size.Width; i++)
                    for (int j = 1; j < bmp.Size.Height; j++)
                    {
                        Color renk = bmp.GetPixel(i, j);

                        kirmizi[renk.R]++;
                        yesil[renk.G]++;
                        mavi[renk.B]++;


                    }
                histogramciz(ref kirmizi, ref yesil, ref mavi);
            }

        }

        int enKucuk,enBuyuk,orta;

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tekrarAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 0;
            pictureBox1.Image = image;
        }

        public void histogramciz(ref int[] red, ref int[] green, ref int[] blue)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
           

            if (a == 1)
            {
                chart1.Series["B"].Color = Color.Gray;
                chart1.Series["R"].Color = Color.Gray;
                chart1.Series["G"].Color = Color.Gray;
                chart1.Series["K"].Color = Color.Gray;
                chart1.Series["M"].Color = Color.Gray;
                chart1.Series["Y"].Color = Color.Gray;
                chart1.Series["C"].Color = Color.Gray;
                for (int i = 1; i < 256; i++)
                {
                    
                    chart1.Series["B"].Points.Add(blue[i] );
                }
            }
            else
            {
                chart1.Series["B"].Color = Color.Blue;
                chart1.Series["R"].Color = Color.Red;
                chart1.Series["G"].Color = Color.Green;
                chart1.Series["K"].Color = Color.Black;
                chart1.Series["M"].Color = Color.Magenta;
                chart1.Series["Y"].Color = Color.Yellow;
                chart1.Series["C"].Color = Color.Cyan;
                

                for (int i = 1; i < 256; i++)
                {
                    //kücük
                    if (red[i] <= blue[i] && red[i] <= green[i])
                    {
                        enKucuk = red[i];

                    }
                    else if (green[i] <= blue[i] && green[i] <= red[i])
                    {
                        enKucuk = green[i];
                    }
                    else  if (blue[i] <= green[i] && blue[i] <= red[i])
                    {
                        enKucuk = blue[i];
                    }

                    //Büyük
                    if (red[i] >= blue[i] && red[i] >= green[i])
                    {
                        enBuyuk = red[i];

                    }
                    else if (green[i] >= blue[i] && green[i] >= red[i])
                    {
                        enBuyuk = green[i];
                    }
                    else if (blue[i] >= green[i] && blue[i] >= red[i])
                    {
                        enBuyuk = blue[i];
                    }

                    //orta
                    if (enBuyuk == blue[i]  &&  enKucuk == green[i])
                    {
                        orta = red[i];

                    }
                    else if (enBuyuk == green[i] && enKucuk == blue[i])
                    {
                        orta = red[i];

                    }
                    else if (enBuyuk == blue[i]   &&  enKucuk == red[i])
                    {
                        orta = green[i];
                    }

                    else if (enBuyuk == red[i] && enKucuk == blue[i])
                    {
                        orta = green[i];
                    }

                    else 
                    {
                        orta = blue[i];
                    }
                    

                    chart1.Series["R"].Points.Add(red[i] );
                    chart1.Series["G"].Points.Add(green[i]);
                    chart1.Series["B"].Points.Add(blue[i] );

                    if((enBuyuk == red[i] && orta == blue[i]) || (orta == red[i] && enBuyuk == blue[i]))
                    {
                        chart1.Series["M"].Points.Add(orta);
                    }
                    else
                    {
                        chart1.Series["M"].Points.Add(0);
                    }

                    if ((enBuyuk == red[i] && orta == green[i]) || (orta == red[i] && enBuyuk == green[i]))
                    {
                        chart1.Series["Y"].Points.Add(orta);
                    }
                    else
                    {
                        chart1.Series["Y"].Points.Add(0);
                    }

                    if ((enBuyuk == green[i] && orta == blue[i]) || (orta == green[i] && enBuyuk == blue[i]))
                    {
                        chart1.Series["C"].Points.Add(orta);
                    }
                    else
                    {
                        chart1.Series["C"].Points.Add(0);
                    }


                    chart1.Series["K"].Points.Add(enKucuk);
                }

            }

        }
     
    }
}

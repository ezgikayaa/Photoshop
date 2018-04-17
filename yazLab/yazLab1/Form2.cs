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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        

        private void boyut_Click(object sender, EventArgs e)
        {


            int genislik = int.Parse(textBox1.Text);
            int yukseklik = int.Parse(textBox2.Text);

            if (Form1.pictureBox1.Image == null)
            {
                MessageBox.Show("Resim seçilmedi !!!");

            }
            else
            {
                Bitmap resim = new Bitmap(Form1.pictureBox1.Image, genislik, yukseklik);

                Form1.pictureBox1.Image = resim;

            }
            Form1.f2.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

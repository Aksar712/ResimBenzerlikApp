using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace ResimBenzerlikApp 
{
    public partial class Form1 : Form
    {
        Bitmap resim1;
        Bitmap resim2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        // -------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                resim1 = new Bitmap(dosyaAc.FileName);
                pictureBox1.Image = resim1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                resim2 = new Bitmap(dosyaAc.FileName);
                pictureBox2.Image = resim2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resim1 == null || resim2 == null)
            {
                MessageBox.Show("Lütfen önce iki resmi de yükleyin.");
                return;
            }

            double oran = BenzerlikHesapla(resim1, resim2);
            label1.Text = "Benzerlik Oranı: %" + (oran * 100).ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            resim1 = null;
            resim2 = null;
            label1.Text = "Sonuç bekleniyor...";
        }

        private double BenzerlikHesapla(Bitmap img1, Bitmap img2)
        {
            Bitmap kucuk1 = new Bitmap(img1, new Size(16, 16));
            Bitmap kucuk2 = new Bitmap(img2, new Size(16, 16));

            int dogruPikselSayisi = 0;
            int toplamPiksel = 256;

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    Color c1 = kucuk1.GetPixel(x, y);
                    Color c2 = kucuk2.GetPixel(x, y);

                    int fark = Math.Abs(c1.R - c2.R) + Math.Abs(c1.G - c2.G) + Math.Abs(c1.B - c2.B);
                    if (fark < 50) dogruPikselSayisi++;
                }
            }
            return (double)dogruPikselSayisi / toplamPiksel;
        }
    }
}

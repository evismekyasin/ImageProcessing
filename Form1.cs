using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntuisleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image ilkhal;
        Bitmap bmp;
        // Resim secme
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";
            ofd.Title = "Bir resim dosyası seçiniz.";
            if(ofd.ShowDialog()!=System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = ofd.FileName;


        }
        // Resmin ilk haline donme
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ilkhal = pictureBox1.Image;
            bmp = new Bitmap(ilkhal);
        }
        private void ilkhali_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = bmp;
        }

        // Resmi gri yapma
        private void gri_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(image);

            pictureBox1.Image = gri;

        }
        private Bitmap griYap(Bitmap griyap)
        {
            for (int i = 0; i < griyap.Height-1; i++)
            {
                for (int j = 0; j < griyap.Width-1; j++)
                {
                    int deger = (griyap.GetPixel(j, i).R + griyap.GetPixel(j, i).G + griyap.GetPixel(j, i).B) / 3;

                    Color renk;
                    renk = Color.FromArgb(deger,deger,deger);
                    griyap.SetPixel(j, i, renk);
                }
            }
            return griyap;
        }

        // Resmin parlakligini textbox ile ayarlama
        private void parlaklik_Click(object sender, EventArgs e)
        {
            int parlakdeger = Convert.ToInt32(textBox1.Text);
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap parlaklik = parlaklikAyarla(image,parlakdeger);

            pictureBox1.Image = parlaklik;

        }
        private Bitmap parlaklikAyarla(Bitmap parlak,int parlakdeger)
        {
            for (int i = 0; i < parlak.Height - 1; i++)
            {
                for (int j = 0; j < parlak.Width - 1; j++)
                {
                    int kirmizideger = parlak.GetPixel(j, i).R + parlakdeger;
                    int yesildeger = parlak.GetPixel(j, i).G + parlakdeger;
                    int mavideger = parlak.GetPixel(j, i).B+parlakdeger;
                    if (kirmizideger < 0) kirmizideger = 0;
                    if (kirmizideger >255 ) kirmizideger = 255;
                    if (yesildeger < 0) yesildeger = 0;
                    if (yesildeger >255) yesildeger = 255;
                    if (mavideger < 0) mavideger = 0;
                    if (mavideger > 255) mavideger = 255;

                    Color renk;
                    renk = Color.FromArgb(kirmizideger, yesildeger, mavideger);
                    parlak.SetPixel(j, i, renk);
                }
            }
            return parlak;
        }

        // Resim histogram esitleme
        private void histogram_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap histogram = histogramYap(image);

            pictureBox1.Image = histogram;
        }
        private Bitmap histogramYap(Bitmap histogramyap)
        {
            uint pixels = (uint)histogramyap.Height * (uint)histogramyap.Width;
            decimal Const = 255 / (decimal)pixels;

            int[] histogramKirmizi = new int[256];
            int[] histogramYesil = new int[256];
            int[] histogramMavi = new int[256];

            for (int i = 0; i < histogramyap.Height; i++)
            {
                for (int j = 0; j < histogramyap.Width; j++)
                {
                    histogramKirmizi[histogramyap.GetPixel(j,i).R]++;
                    histogramYesil[histogramyap.GetPixel(j,i).G]++;
                    histogramMavi[histogramyap.GetPixel(j,i).B]++;
                }
            }

            int[] histogramKirmiziK = histogramKirmizi;
            int[] histogramYesilK = histogramYesil;
            int[] histogramMaviK = histogramMavi;
            for (int i = 1; i <= 255; i++)
            {
                histogramKirmiziK[i] = histogramKirmiziK[i] + histogramKirmiziK[i - 1];
                histogramYesilK[i] = histogramYesilK[i] + histogramYesilK[i - 1];
                histogramMaviK[i] = histogramMaviK[i] + histogramMaviK[i - 1];
            }

            for (int i = 0; i < histogramyap.Height; i++)
            {
                for (int j = 0; j < histogramyap.Width; j++)
                {
                    Color renk = histogramyap.GetPixel(j, i);
                    int kirmizi = (int)((decimal)histogramKirmiziK[renk.R] * Const);
                    int yesil = (int)((decimal)histogramYesilK[renk.G] * Const);
                    int mavi = (int)((decimal)histogramMaviK[renk.B] * Const);
                    Color yenirenk = Color.FromArgb(kirmizi,yesil,mavi);
                    histogramyap.SetPixel(j,i,yenirenk);
                }
            }

            return histogramyap;
        }

       
    }
}

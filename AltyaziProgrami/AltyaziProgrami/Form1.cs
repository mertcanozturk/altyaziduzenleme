using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltyaziProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int satirSayisi = 0;
        public string dosyaYolu, dosyaAdi, gecenZaman;
        DateTime dt;
        private void btnAltyaziSec_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Altyazı Dosyası |*.srt| Altyazı Dosyası|*.srt";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Altyazı Dosyası Seçiniz..";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = file.FileName;
                dosyaAdi = file.SafeFileName;
                dosyaOku();
            }

        }
        public void dosyaOku()
        {
            txtIcerik.Clear();
            StreamReader SR = new StreamReader(dosyaYolu, Encoding.GetEncoding("iso-8859-9"));
            string metin = SR.ReadLine();
            lblLoading.Visible = true;
            panel1.Enabled = false;
            while (metin != null)
            {
                txtIcerik.Text = txtIcerik.Text + metin + "\n";
                metin = SR.ReadLine();
                satirSayisi += 1;
            }
            lblAltyaziAdi.Text = dosyaAdi;
            panel1.Enabled = true;
            lblLoading.Visible = false;
            TimeSpan fark = DateTime.Now - dt;
            gecenZaman = fark.Seconds.ToString() + " saniye " + fark.Milliseconds.ToString() + " milisaniye";
            lblSure.Text = gecenZaman;

        }

        public string geriAl(int miktar)
        {
            string metin = txtIcerik.Text;
            string[] satirlar = metin.Split('\n');
            string[] yeniAyrikMetin = new string[satirSayisi + 15];
            string yeniMetin = "";
            int sayac = 0;
            foreach (var item in satirlar)
            {
                if (item.Length == 29 && item[15] == '>')
                {
                    //00:00:00,768 --> 00:00:05,200
                    string ilkZaman = item.Substring(0, 12);
                    string sonZaman = item.Substring(16, 13);
                    string[] dizi = ilkZaman.Split(',');
                    int salise = int.Parse(dizi[1]);
                    string yeniIlkZaman = cikar(ilkZaman, miktar);
                    string yeniSonZaman = cikar(sonZaman.Remove(0, 1), miktar);
                    yeniAyrikMetin[sayac] = yeniIlkZaman + " --> " + yeniSonZaman;

                }
                else
                    yeniAyrikMetin[sayac] = item;
                sayac++;
            }
            yeniMetin = string.Join("\n", yeniAyrikMetin);
            return yeniMetin;
        }

        public string ileriAl(int miktar)
        {
            string metin = txtIcerik.Text;
            string[] satirlar = metin.Split('\n');
            string[] yeniAyrikMetin = new string[satirSayisi + 15];
            string yeniMetin = "";
            int sayac = 0;
            foreach (var item in satirlar)
            {
                if (item.Length == 29 && item[15] == '>')
                {
                    //00:00:00,768 --> 00:00:05,200
                    string ilkZaman = item.Substring(0, 12);
                    string sonZaman = item.Substring(16, 13);
                    string[] dizi = ilkZaman.Split(',');
                    int salise = int.Parse(dizi[1]);
                    string yeniIlkZaman = ekle(ilkZaman, miktar);
                    string yeniSonZaman = ekle(sonZaman.Remove(0, 1), miktar);
                    yeniAyrikMetin[sayac] = yeniIlkZaman + " --> " + yeniSonZaman;

                }
                else
                    yeniAyrikMetin[sayac] = item;
                sayac++;
            }
            yeniMetin = string.Join("\n", yeniAyrikMetin);
            return yeniMetin;
        }

        public string cikar(string metin, int miktar)
        {
            //  " 00:00:08,948"

            string yeniMetin = "";
            string[] zaman = metin.Split(',');
            int salise = int.Parse(zaman[1]);
            salise -= miktar;
            string[] ayrikZaman = zaman[0].Split(':');
            string[] yeniAyrikZaman = new string[3];
            int sayi = 0;
            if (salise < 0)
            {
                salise = 1000 + salise;
                sayi = int.Parse(ayrikZaman[2]);
                if (sayi != 0)
                {
                    sayi--;
                    if (sayi < 10)
                        yeniAyrikZaman[2] = "0" + sayi.ToString();
                    else
                        yeniAyrikZaman[2] = sayi.ToString();
                    yeniAyrikZaman[1] = ayrikZaman[1];
                    yeniAyrikZaman[0] = ayrikZaman[0];
                }
                else
                {
                    yeniAyrikZaman[2] = "59";
                    sayi = int.Parse(ayrikZaman[1]);
                    if (sayi != 0)
                    {
                        sayi--;
                        if (sayi < 10)
                            yeniAyrikZaman[1] = "0" + sayi.ToString();
                        else
                            yeniAyrikZaman[1] = sayi.ToString();
                        yeniAyrikZaman[0] = ayrikZaman[0];
                    }
                    else
                    {
                        yeniAyrikZaman[1] = "59";
                        sayi = int.Parse(ayrikZaman[0]);
                        sayi--;
                        if (sayi < 0)
                        {
                            yeniAyrikZaman[0] = "00";
                            yeniAyrikZaman[1] = "00";
                            yeniAyrikZaman[2] = "00";
                            salise = 0;
                        }
                        else
                        {
                            if (sayi < 10)
                                yeniAyrikZaman[0] = "0" + sayi.ToString();
                            else
                                yeniAyrikZaman[0] = sayi.ToString();
                        }
                    }
                }
            }
            else
            {
                yeniAyrikZaman[2] = ayrikZaman[2];
                yeniAyrikZaman[1] = ayrikZaman[1];
                yeniAyrikZaman[0] = ayrikZaman[0];
            }

            if (salise < 10)
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + "00" + salise.ToString();
            else if (salise < 100)
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + "0" + salise.ToString();
            else
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + salise.ToString();
            return yeniMetin;
        }


        public string ekle(string metin, int miktar)
        {
            //  " 00:00:08,948"
            string yeniMetin = "";
            string[] zaman = metin.Split(',');
            int salise = int.Parse(zaman[1]);
            salise += miktar;

            string[] ayrikZaman = zaman[0].Split(':');
            string[] yeniAyrikZaman = new string[3];

            int sayi = 0;
            if (salise >= 1000)
            {
                salise = salise - 1000;
                //" 00:00:08,948"
                sayi = int.Parse(ayrikZaman[2]);
                sayi++;
                if (sayi == 60)
                {
                    yeniAyrikZaman[2] = "00";
                    sayi = int.Parse(ayrikZaman[1]);
                    sayi++;
                    if (sayi == 60)
                    {
                        yeniAyrikZaman[1] = "00";
                        sayi = int.Parse(ayrikZaman[0]);
                        sayi++;
                        yeniAyrikZaman[0] = "0" + sayi.ToString();
                    }
                    else
                    {
                        if (sayi < 10)
                            yeniAyrikZaman[1] = "0" + sayi.ToString();
                        else
                            yeniAyrikZaman[1] = sayi.ToString();

                        yeniAyrikZaman[0] = ayrikZaman[0];
                    }
                }
                else
                {
                    if (sayi < 10)
                        yeniAyrikZaman[2] = "0" + sayi.ToString();
                    else
                        yeniAyrikZaman[2] = sayi.ToString();

                    sayi = int.Parse(ayrikZaman[1]);
                    yeniAyrikZaman[1] = ayrikZaman[1];
                    yeniAyrikZaman[0] = ayrikZaman[0];
                }
            }
            else
            {//
                yeniAyrikZaman[2] = ayrikZaman[2];
                yeniAyrikZaman[1] = ayrikZaman[1];
                yeniAyrikZaman[0] = ayrikZaman[0];
                if (salise < 10)
                    yeniMetin = metin.Substring(0, 8) + "," + "00" + salise.ToString();
                else if (salise < 100)
                    yeniMetin = metin.Substring(0, 8) + "," + "0" + salise.ToString();
                else
                    yeniMetin = metin.Substring(0, 8) + "," + salise.ToString();

                return yeniMetin;
            }

            if (salise < 10)
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + "00" + salise.ToString();
            else if (salise < 100)
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + "0" + salise.ToString();

            else
                yeniMetin = string.Join(":", yeniAyrikZaman) + "," + salise.ToString();
            salise = 0;
            return yeniMetin;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = ileriAl(500);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = ileriAl(1000);
        }

        private void btneksi25_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = geriAl(250);
        }

        private void btneksi50_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = geriAl(500);

        }

        private void btneksi1_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = geriAl(1000);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        static void WriteAllText(string path, string txt)
        {
            var bytes = Encoding.UTF8.GetBytes(txt);
            using (var f = File.OpenWrite(path))
            {
                f.Write(bytes, 0, bytes.Length);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var stream = File.CreateText("mert.txt"))
            {
                stream.Write(txtIcerik);
                //..
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = ileriAl(250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

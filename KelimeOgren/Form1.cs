using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Access veritabanı için gerekli kütüphane

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        private string sonKullanici;

        public Form1(string sonKullanici)
        {
            InitializeComponent();
            this.sonKullanici = sonKullanici;
        }

        // Access veritabanı bağlantısı 
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vural\source\dbSozluk.accdb");
        Random rnd = new Random();
        int sure = 10;      //Süre
        int kelime = 0;

        private void Getir()
        {
            int sayi = 0;
            sayi = rnd.Next(2502, 2551);
            LblCevap.Text = sayi.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk2 where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txtİngilizce.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
            TxtTurkce.Focus();
            LblKullanıcıAd.Text = $"Hoşgeldin {sonKullanici.ToUpper()}";
        }


        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (TxtTurkce.Text == LblCevap.Text)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                Getir();
                TxtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtTurkce.Enabled = false;
                Txtİngilizce.Enabled = false;
                MessageBox.Show("Süre Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
                BtnBilmiyorum.Enabled = false;  
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcı adını ve puanını database kaydetme
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kullanıcı (Ad,Puan) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", LblKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", LblKelime.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            timer1.Stop();
            string puan = LblKelime.Text;
            MessageBox.Show($"Kullanıcı Adı: {sonKullanici}\nPuanınız: {puan}",
                          "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBilmiyorum_Click(object sender, EventArgs e)
        {
            Getir();
        }
    }
    }


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
        int sure = 90;      //Süre
        int kelime = 0;

        private void Getir()
        {
            int sayi = 0;
            sayi = rnd.Next(1, 2490);
            LblCevap.Text = sayi.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
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
            LblKullanıcıAd.Text = sonKullanici.ToString();
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
            }
        }
    }
}

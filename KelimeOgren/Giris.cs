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
    public partial class Giris : Form
    {
        private string sonKullanici;
 
        public Giris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\vural\source\dbSozluk.accdb");


        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adını database kaydetme
            baglanti.Open();    
            OleDbCommand komut = new OleDbCommand("insert into Kullanıcı (Ad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text); 
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kullanıcı adı kaydedildi.");
            string kullaniciAdi = TxtKullanıcıAd.Text.Trim();
            sonKullanici = kullaniciAdi;
            // Form1'e geçiş
            Form1 frm = new Form1(sonKullanici);
            frm.Show();
            this.Hide();
        }
    }
}

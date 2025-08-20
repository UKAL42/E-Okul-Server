using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//Data Source=YAZILIMPC-15;Initial Catalog=GirisBilgi;Integrated Security=True;Trust Server Certificate=True
namespace EOkul
{
    public partial class Login : Form
    {
        public partial class Global
        {
            public static string globalKulllaniciSinif;
            public static string kullaniciID;
        }
        readonly SqlConnection baglanti = new SqlConnection(@"Data Source=YAZILIMPC-15;Initial Catalog=DBOgrenciNot;Integrated Security=True;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            pnlMain.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnSubmit.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
            
            public void BtnSubmit_Click(object sender, EventArgs e)
            {
                if (GirisMiKayıtMı.Checked == false)
                {
                    FGirisYap();
                }
                else
                {
                    FKaydol();
                }
            }

        private void FGirisYap()//Giriş Fonksiyonu
        {
            //Parola Şifreleme
            string sifrelenmisSifre = FMD5Sifreleme(txtSifre.Text);


            //Kullanıcı Adı ve Parola Kontrolü
            SqlCommand komut = new SqlCommand("Select * From TBLGIRISBILGI where KULLANICIAD = @KAdi and PAROLA = @KParola", baglanti);
            komut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
            komut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);


            //Kullanıcı Tipi Tespiti
            SqlCommand turkomut = new SqlCommand("SELECT TBLKULLANICIBILGI.TURID FROM TBLGIRISBILGI INNER JOIN TBLKULLANICIBILGI ON TBLKULLANICIBILGI.ID = TBLGIRISBILGI.OGRID WHERE TBLGIRISBILGI.KULLANICIAD = @KAdi AND TBLGIRISBILGI.PAROLA = @KParola", baglanti);
            turkomut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
            turkomut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);

            baglanti.Open();

            //Kullanıcı Tipi Değişken Ataması (Tek değer olduğundan ExecuteScalar komutu ile atama yapılıyor.)
            object sonuc = turkomut.ExecuteScalar();

            //Data Adapter ile veri dönüştürülüyor.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //Data Table Tanımlaması Yapılıyor
            DataTable dt = new DataTable();
            //Data Adapter veriyi Data Table'A yediriyor.
            da.Fill(dt);

            baglanti.Close();


            if (sonuc != null)
            {
                Global.globalKulllaniciSinif = Convert.ToString(sonuc);
                //Eğer Parola Eşleşmesi Varsa Gİriş Başarılı Mesajı Gösteriliyor Ve Ana Panel Açılıyor.
                int row = dt.Rows.Count;
                if (row > 0)
                {
                    MessageBox.Show("Giriş Başarılı!");
                    this.Hide();
                    AnaMenuOgretmen fr = new AnaMenuOgretmen();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız!");
                }
                txtSifre.Text = "";
            }
        }

        private void FKaydol()//Kayıt Oluşturma Fonksiyonu
        {
            while (true)
            {   //Format Kontrolü
                if ((txtKAdi.Text).Length <= 25 && (txtKAdi.Text).Length > 4 && (txtSifre.Text).Length <= 30 && (txtSifre.Text).Length <= 30 && (txtSifre.Text).Length > 8 && !Regex.IsMatch(txtKAdi.Text, @"[çÇğĞıİöÖşŞüÜ\s]"))
                {
                    //Parola Şifreleme Fonksiyonu Çağrılıyor.
                    string sifrelenmisSifre = FMD5Sifreleme(txtSifre.Text);

                    baglanti.Open();
                    //Kullanıcı Bilgileri Veritabanına TBLKULLANICIBILGI Tablosuna İşlenir
                    SqlCommand komut = new SqlCommand(@"Insert Into TBLGIRISBILGI (KULLANICIAD, PAROLA) values (@KAdi, @KParola) SELECT * From TBLKULLANICIBILGI WHERE KULLANICIAD = @KAdi AND PAROLA = @KParola", baglanti);
                    komut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
                    komut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);
                    object id = komut.ExecuteScalar();
                    Global.kullaniciID = Convert.ToString(id);
                    SqlCommand komut2 = new SqlCommand("INSERT INTO TBLKULLANICIBILGI (OGRID, OGRAD, OGRSOYAD, OGRCINSIYET) VALUES (@ogrID, @ogrAD, @ogrSoyad, @ogrCinsiyet)", baglanti);
                    komut2.Parameters.AddWithValue("@ogrID", id);
                    komut2.Parameters.AddWithValue("@ogrAD", txtKullaniciAd.Text);
                    komut2.Parameters.AddWithValue("@ogrSoyad", txtKullaniciSoyad);
                    komut2.Parameters.AddWithValue("@ogrCinsiyet", cbKullaniciCinsiyet.Text);
                    komut2.ExecuteNonQuery();
                    
                    baglanti.Close();

                    txtKAdi.Text = "";
                    txtSifre.Text = "";
                    txtKullaniciAd.Text = "";
                    txtKullaniciSoyad.Text = "";
                    cbKullaniciCinsiyet.Text = "";


                    MessageBox.Show("Kullanıcı Başarıyla Eklendi!");
                    break;
                }
                else
                {
                    MessageBox.Show("Lütfen Uygun Formatta Giriş Yapınız.");
                    break;
                }
            }
        }
        public static string FMD5Sifreleme(string girdi)
        {
            byte[] encodedSifre = new UTF8Encoding().GetBytes(girdi);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedSifre);
            string sifrelenmisSifre = BitConverter.ToString(hash)
            .Replace("-", string.Empty)
            .ToLower();
            return sifrelenmisSifre;
        }

        private void GirisMiKayıtMı_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox groupBoxKayit = new GroupBox();

            if (lblBaslik.Text == "Giriş")
            {
                groupBoxKayit.Enabled = true;
                groupBoxKayit.Visible = true;
                lblBaslik.Text = "Kayıt";
                GirisMiKayıtMı.Checked = true;
            }
            else
            {
                groupBoxKayit.Enabled = false;
                groupBoxKayit.Visible = false;
                lblBaslik.Text = "Giriş";
                GirisMiKayıtMı.Checked = false;
            }
        }
    }
}

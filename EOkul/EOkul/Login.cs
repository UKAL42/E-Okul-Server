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
        public partial class global
        {
            public static string globalKulllaniciSinif;
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

        private void FGirisYap()
        {
            string sifrelenmisSifre = FMD5Sifreleme(txtSifre.Text);

            SqlCommand komut = new SqlCommand("Select * From TBLKULLANICIBILGI where KULLANICIAD = @KAdi and PAROLA = @KParola", baglanti);
            komut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
            komut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);

            SqlCommand turkomut = new SqlCommand("SELECT TURID FROM TBLKULLANICIBILGI WHERE KULLANICIAD=@KAdi AND PAROLA=@KParola", baglanti);
            turkomut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
            turkomut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);

            baglanti.Open();

            object sonuc = turkomut.ExecuteScalar();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            baglanti.Close();

            if (sonuc != null)
            {
                global.globalKulllaniciSinif = Convert.ToString(sonuc);

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

        private void FKaydol()
        {
            while (true)
            {
                if ((txtKAdi.Text).Length <= 25 && (txtKAdi.Text).Length > 4 && (txtSifre.Text).Length <= 30 && (txtSifre.Text).Length <= 30 && (txtSifre.Text).Length > 8 && !Regex.IsMatch(txtKAdi.Text, @"[çÇğĞıİöÖşŞüÜ\s]"))
                {
                    string sifrelenmisSifre = FMD5Sifreleme(txtSifre.Text);
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert Into TBLKULLANICIBILGI (KULLANICIAD, PAROLA) values (@KAdi, @KParola)", baglanti);
                    komut.Parameters.AddWithValue("@KAdi", txtKAdi.Text);
                    komut.Parameters.AddWithValue("@KParola", sifrelenmisSifre);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    txtKAdi.Text = "";
                    txtSifre.Text = "";
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
        public string FMD5Sifreleme(string girdi)
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
            if (lblBaslik.Text == "Giriş")
            {
                lblBaslik.Text = "Kayıt";
                GirisMiKayıtMı.Checked = true;
            }
            else
            {
                lblBaslik.Text = "Giriş";
                GirisMiKayıtMı.Checked = false;
            }
        }
    }
}

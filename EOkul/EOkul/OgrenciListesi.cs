using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EOkul
{
    public partial class OgrenciListesi : Form
    {
        readonly SqlConnection baglanti = new SqlConnection(@"Data Source=YAZILIMPC-15;Initial Catalog=DBOgrenciNot;Integrated Security=True;TrustServerCertificate=True");
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT OGRCINSIYET,OGRAD + ' ' + OGRSOYAD AS 'AD SOYAD',KULLANICIAD AS 'KULLANICI ADI' FROM TBLKULLANICIBILGI WHERE TURID = 3;", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EOkul
{
    public partial class AnaMenuOgretmen : Form
    {
        public AnaMenuOgretmen()
        {
            InitializeComponent();
        }
        readonly SqlConnection baglanti = new SqlConnection(@"Data Source=YAZILIMPC-15;Initial Catalog=DBOgrenciNot;Integrated Security=True;TrustServerCertificate=True");

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            pnlLeftSide.BackColor = Color.FromArgb(100, 0, 0, 0);
            grboxLeftSide.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void BtnOgrListe_Click(object sender, EventArgs e)
        {
            Form fr = new OgrenciListesi();
            FFormAc(ref fr);
        }

        private void BtnNotlar_Click(object sender, EventArgs e)
        {
            Form fr = new Notlar();
            FFormAc(ref fr);

        }

        private void BtnDersler_Click(object sender, EventArgs e)
        {
            Form fr = new Dersler();
            FFormAc(ref fr);
        }

        private void BtnKulupler_Click(object sender, EventArgs e)
        {
            Form fr = new Kulupler();
            FFormAc(ref fr);

        }

        private void BtnDersProgrami_Click(object sender, EventArgs e)
        {
            Form fr = new DersProgrami();
            FFormAc(ref fr);
        }
        void FFormAc(ref Form form)
        {
            Form f = form;

            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
            f.Size = new Size(1506, 949);
            f.Location = new Point(0,0);
        }
    }
}

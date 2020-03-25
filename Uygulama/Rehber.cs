using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Uygulama
{
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(" Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\RehberForm.mdb");


        private void verilerigoruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("select * from Rehber");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                listView1.Items.Add(ekle);
                
            }
            baglanti.Close();
        }
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            menu.Show();
            this.Close();
        }

        private void btnRehberGor_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }
    }
}
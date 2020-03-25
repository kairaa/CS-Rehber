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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\RehberForm.mdb");
        

        private void btnMenü_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            menu.Show();
            this.Close();
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from Rehber where Ad='" + tbSilAd.Text + "'";
                if (tbSilAd.Text == "")
                {
                    MessageBox.Show("Yukarıdaki Alanı Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kişi Başarıyla Rehberden Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Silme Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}

            


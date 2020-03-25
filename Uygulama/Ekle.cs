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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

      private void btnMenu_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            menu.Show();
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using(OleDbConnection baglanti =new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\RehberForm.mdb"))
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Rehber (Ad,Soyad,Telefon) values (?,?,?)",baglanti);
                    komut.Parameters.AddWithValue("Ad", tbAd.Text);
                    komut.Parameters.AddWithValue("Soyad", tbSoyad.Text);
                    komut.Parameters.AddWithValue("Telefon", tbTel.Text);
                    if (tbAd.Text == "" || tbSoyad.Text == "" || tbTel.Text == "")
                    {
                        MessageBox.Show("Lütfen Yukarıda Boş Alan Bırakmayın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        komut.Connection = baglanti;
                        komut.CommandText="delete from Rehber where Ad='"+tbAd.Text+"'";
                    }
                    else
                    {
                        MessageBox.Show("Kişi Rehbere Başarıyla Eklendi", "Kişi Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
    }
}

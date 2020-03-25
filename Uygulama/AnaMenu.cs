using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnRehber_Click(object sender, EventArgs e)
        {
            Rehber rehber = new Rehber();
            rehber.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle kayit = new Ekle();
            kayit.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.Show();
            this.Hide();
        }
    }
}

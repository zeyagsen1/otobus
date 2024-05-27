using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otogar
{
    public partial class YoneticiGirisEkrani : Form
    {
        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }

        public static string Yonetici = "admin";
        public static string parola = "admin";

        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtparola.Text == "" || txtkullaniciadi.Text == "Kullanıcı Adınız" || txtparola.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtkullaniciadi.Text == Yonetici && txtparola.Text == parola)
                {
                    Form10 menu = new Form10();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            this.Hide();
            ana.Show();
        }

        private void btnkullaniciduzenle_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtparola.Text == "" || txtkullaniciadi.Text == "Kullanıcı Adınız" || txtparola.Text == "Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtkullaniciadi.Text == Yonetici && txtparola.Text == parola)
                {
                    Form3 parolad = new Form3();
                    this.Hide();
                    parolad.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

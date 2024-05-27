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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnkullaniciduzenle_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadiekle.Text == "" || txtparolaekle.Text == "" || txtkullaniciadiekle.Text == "Yeni Kullanıcı Adınız" || txtparolaekle.Text == "Yeni Parolanız")
            {
                MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                YoneticiGirisEkrani.Yonetici = txtkullaniciadiekle.Text;
                YoneticiGirisEkrani.parola = txtparolaekle.Text;
                MessageBox.Show("Kullanıcı adı ve parola başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                YoneticiGirisEkrani menu = new YoneticiGirisEkrani();
                this.Hide();
                menu.Show();
            }
        }

        private void txtkullaniciadiekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtparolaekle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

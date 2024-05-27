using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static otogar.Form10;
using System.Data.SqlClient;
using System.Collections;




namespace otogar
{
    public partial class Form5 : Form
    {
        SqlConnection conn;

        public Form5()
        {
            InitializeComponent();
            

        }

        string ad, soyad;
        int koltukno, sayac = 0, boskoltuk = 31, dolukoltuk = 0;

        private void uygulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void anaEkranaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 iptal = new Form10();

            iptal.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtiptalkoltukno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbliptaledilenkoltukno_Click(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 menu = new Form10();
            this.Hide();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            if (textisim.Text == "" || txtsoyisim.Text == "" || txtkoltukno.Text == "" || txttelefon.Text == "") MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(rderkek.Checked || rdkadin.Checked)) MessageBox.Show("Lütfen cinsiyet seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {
                    
                    

                   


                    
                    ad = textisim.Text;
                    soyad = txtsoyisim.Text;
                    koltukno = Convert.ToInt32(txtkoltukno.Text);
                    if (koltukno < 1 || koltukno > 31)
                    {
                        MessageBox.Show(koltukno + " fuck");

                        MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtkoltukno.Text = "";
                    }
                    else
                    {

                        if (!ReservationData2.DoluKoltuklar.Contains(koltukno))
                        {
                            string queryy = "INSERT INTO dokuzAraci (isim, soyisim, koltuk,cinsiyet,numara) VALUES (@isim, @soyisim, @koltuk,@cins,@number)";
                            string connection_string = "Data Source=.; Initial Catalog=otobus;Integrated Security=true";
                            SqlConnection con = new SqlConnection(connection_string);
                            con.Open();
                            SqlCommand cmdd = new SqlCommand(queryy, con);
                            ad = textisim.Text;
                            soyad = txtsoyisim.Text;
                            koltukno = Convert.ToInt32(txtkoltukno.Text);


                            cmdd.Parameters.AddWithValue("@isim", ad);
                            cmdd.Parameters.AddWithValue("@soyisim", soyad);
                            cmdd.Parameters.AddWithValue("@koltuk", koltukno);
                            cmdd.Parameters.AddWithValue("@number", txttelefon.Text);
                            if (rdkadin.Checked)
                            {

                                cmdd.Parameters.AddWithValue("@cins", "Kadin");
                            }
                            else
                            {
                                cmdd.Parameters.AddWithValue("@cins", "Erkek");

                            }


                            cmdd.ExecuteNonQuery();

                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;
                            if (koltukara != null)
                            {
                                koltukara.Text += "\r" + ad + " " + soyad;
                                koltukara.BackColor = Color.GreenYellow;

                                dolukoltuk++;
                                boskoltuk--;

                                ReservationData2.DoluKoltuklar.Add(koltukno);
                                ReservationData2.KoltukBilgileri[koltukno] = (ad, soyad, rdkadin.Checked ? "Kadin" : "Erkek");

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();

                                textisim.Text = "";
                                txtsoyisim.Text = "";
                                txtkoltukno.Text = "";
                                txttelefon.Text = "";

                                Image erkek = Image.FromFile("İconlar/E.png");
                                Image kadin = Image.FromFile("İconlar/K.png");
                                koltukara.Image = rdkadin.Checked ? kadin : erkek;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girmiş olduğunuz koltuk numarasına ait koltuk dolu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkoltukno.Text = "";
                        }
                    }
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtkoltukno.Text = "";
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btniptalet_Click_1(object sender, EventArgs e)
        {
            try
            {

                koltukno = Convert.ToInt32(txtiptalkoltukno.Text);



                if (koltukno < 1 || koltukno > 31)
                    {

                        MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtiptalkoltukno.Text = "";
                    }

                    else
                    {
                        if (ReservationData2.DoluKoltuklar.Contains(koltukno))
                        {
                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;
                            if (koltukara != null)
                            {
                                koltukara.Text = koltukno + ".koltuk";
                                koltukara.BackColor = Color.FloralWhite;
                                dolukoltuk--;
                                boskoltuk++;

                                ReservationData2.DoluKoltuklar.Remove(koltukno);
                                ReservationData2.KoltukBilgileri.Remove(koltukno);

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();
                                txtiptalkoltukno.Text = "";

                                Image bos_koltuk = Image.FromFile("İconlar/VarsayılanKoltuk.png");
                                koltukara.Image = bos_koltuk;

                           

                            string deleteQuery = "DELETE FROM dokuzAraci WHERE koltuk = @k";
                            string connectionString = "Data Source=.; Initial Catalog=otobus;Integrated Security=true";





                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                try
                                {
                                    // Open the connection
                                    connection.Open();

                                    // Create a SQL command
                                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                    {
                                        // Add the parameter value
                                        command.Parameters.AddWithValue("@k", koltukno);


                                        command.ExecuteNonQuery();



                                    }
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("İptal edilmek istenen koltuk zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtiptalkoltukno.Text = "";
                        }
                    }

                }
            }

            catch (Exception excep)
            {
                //MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtiptalkoltukno.Text = "";
                MessageBox.Show(excep.Message);
            }
        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            
        }

        int[] dolukoltukdizi = new int[0];

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connection_string = "Data Source=.; Initial Catalog=otobus;Integrated Security=true";
            conn = new SqlConnection(connection_string);
            conn.Open();
            string query = "Select * from dokuzAraci";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList a = new ArrayList();


            while (reader.Read())
            {

                if (!ReservationData2.DoluKoltuklar.Contains(reader.GetInt32(2))) {

                    ReservationData2.DoluKoltuklar.Add(reader.GetInt32(2));
                    ReservationData2.KoltukBilgileri[reader.GetInt32(2)] = (reader.GetString(0), reader.GetString(1),reader.GetString(3));


                }
                



            }



            dolukoltuk = ReservationData2.DoluKoltuklar.Count;
            boskoltuk = 31 - dolukoltuk;

            foreach (var koltuk in ReservationData2.DoluKoltuklar)
            {
               
                var info = ReservationData2.KoltukBilgileri[koltuk];
                Label koltukara = this.Controls.Find("koltuk" + koltuk.ToString(), true).FirstOrDefault() as Label;
                if (koltukara != null)
                {
                    koltukara.Text += "\r" + info.Ad + " " + info.Soyad;
                    koltukara.BackColor = Color.GreenYellow;

                    Image erkek = Image.FromFile("İconlar/E.png");
                    Image kadin = Image.FromFile("İconlar/K.png");
                    koltukara.Image = info.Cinsiyet == "Kadin" ? kadin : erkek;
                }
            }

            lbldolu.Text = dolukoltuk.ToString();
            lblbos.Text = boskoltuk.ToString();
        }
    }
}

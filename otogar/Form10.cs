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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public static class ReservationData
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }
        public static class ReservationData2
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }
        public static class ReservationData3
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }
        public static class ReservationData4
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }
        public static class ReservationData5
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }
        public static class ReservationData6
        {
            public static List<int> DoluKoltuklar = new List<int>();
            public static Dictionary<int, (string Ad, string Soyad, string Cinsiyet)> KoltukBilgileri = new Dictionary<int, (string Ad, string Soyad, string Cinsiyet)>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 plaka1 = new Form4();
            
            plaka1.Show();
        }

        private void anaEkranaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 plaka1 = new Form5();

            plaka1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 plaka1 = new Form6();

            plaka1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}

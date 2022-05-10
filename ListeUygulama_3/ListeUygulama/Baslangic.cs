using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeUygulama
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeToplam lt = new ListeToplam();
            lt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kronometre kr = new Kronometre();
            kr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AsalSayiListele asl = new AsalSayiListele();
            asl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HareketEtme hrk = new HareketEtme();
            hrk.Show();
        }
    }
}

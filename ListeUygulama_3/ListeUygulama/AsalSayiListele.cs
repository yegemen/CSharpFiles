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
    public partial class AsalSayiListele : Form
    {

        Timer timer2 = new Timer();
        public int say;

        public AsalSayiListele()
        {
            InitializeComponent();
        }

        private bool AsalMi(int sayi)
        {
            int k = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    k++;
                }
            }
            if (k <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AsalSayiListele_Load(object sender, EventArgs e)
        {
            timer1.Enabled = timer2.Enabled = false;
            say = 0;
            timer2.Interval = 100; //100ms de bir çalışacak.
            timer2.Tick += new EventHandler(timer2_Tick); //timer 2 yi kod ile eklediğimiz için bu satırı yazdık.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //timer1.start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;
            if (say>100)
            {
                timer1.Enabled = timer2.Enabled = false;
            }
            else
            {
                if (AsalMi(say))
                    listBox1.Items.Add(say);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            say++;
            if(say>100)
            {
                timer1.Enabled = timer2.Enabled = false;
            }
            else
            {
                if (AsalMi(say))
                    listBox2.Items.Add(say.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer2.Enabled = false;
        }
    }
}

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
    public partial class Kronometre : Form
    {

        private int saniye;
        private int dakika;
        private int saat;
        public Kronometre()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Start(); //start ile enabled aynı işi yapıyorlar farklı olduğu durumlarda var.   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (timer1.Enabled) // == true de yazabilirdik devamına
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Kronometre_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1; // 1 ms

            saniye = 0;
            dakika = 0;
            saat = 0;

            ToolTip aciklama = new ToolTip();
            aciklama.ToolTipIcon = ToolTipIcon.Error;
            aciklama.ToolTipTitle = "Uyarı";
            aciklama.SetToolTip(button1, "Timer Harekete Geçer");
            aciklama.SetToolTip(button2, "Timer Durur");

            toolTip1.SetToolTip(button3, "Timer başlar ve durur");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if(saniye >= 60)
            {
                dakika++;
                saniye = 0;
            }
            if(dakika>=60)
            {
                saat++;
                dakika = 0;
            }
            label1.Text = "Saat:" + saat + ":" + dakika + ":" + saniye;
        }
    }
}

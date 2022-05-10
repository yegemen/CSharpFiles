using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (radioButton1.Checked == true)
                {
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                }
                else if (radioButton1.Checked == true)
                {
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
                }
                else if (radioButton1.Checked == true)
                {
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
                }
                else if (radioButton1.Checked == true)
                {
                    textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli değer girin !");
                
            }            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void SecmeIslemi_Bolme(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}

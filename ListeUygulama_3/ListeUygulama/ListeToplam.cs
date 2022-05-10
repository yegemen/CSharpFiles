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
    public partial class ListeToplam : Form
    {
        public ListeToplam()
        {
            InitializeComponent();
        }
        int toplam;

        private void ListeToplam_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i)) // i. eleman seçilimi değil mi onu kontrol ediyor.
                    toplam += Convert.ToInt32(listBox1.Items[i]);
            }
            MessageBox.Show("Toplam = " + toplam);
        }
    }
}

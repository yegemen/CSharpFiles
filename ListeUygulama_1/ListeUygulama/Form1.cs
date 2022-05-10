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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sag;

            for (sag = listBox1.SelectedIndices.Count - 1; sag >= 0; sag--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[sag]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[sag]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sol;

            for (sol = listBox2.SelectedIndices.Count - 1; sol >= 0; sol--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[sol]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[sol]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }
    }
}

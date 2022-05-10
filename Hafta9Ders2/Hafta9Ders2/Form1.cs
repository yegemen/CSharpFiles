﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta9Ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string ilk = textBox1.Text;
            char[] yeni = textBox1.Text.ToCharArray();

            for (int i = 0; i < yeni.Length; i++)
            {
                switch (yeni[i])
                {
                    case '+':
                        {
                            string[] dizi;
                            dizi = textBox1.Text.Split('+');
                            textBox1.Text = ilk + "=" + (int.Parse(dizi[0]) + int.Parse(dizi[1])).ToString();
                            break;
                        }  
                    case '-':
                        {
                            string[] dizi;
                            dizi = textBox1.Text.Split('-');
                            textBox1.Text = ilk + "=" + (int.Parse(dizi[0]) - int.Parse(dizi[1])).ToString();
                            break;
                        }
                    case '*':
                        {
                            string[] dizi;
                            dizi = textBox1.Text.Split('*');
                            textBox1.Text = ilk + "=" + (int.Parse(dizi[0]) * int.Parse(dizi[1])).ToString();
                            break;
                        }
                    case '/':
                        {
                            string[] dizi;
                            dizi = textBox1.Text.Split('/');
                            textBox1.Text = ilk + "=" + (int.Parse(dizi[0]) / int.Parse(dizi[1])).ToString();
                            break;
                        }
                    case '^':
                        {
                            string[] dizi;
                            dizi = textBox1.Text.Split('^');
                            textBox1.Text = ilk + "=" + Math.Pow(int.Parse(dizi[0]), int.Parse(dizi[1])).ToString();
                            break;
                        }

                }
            }
        }
    }
}

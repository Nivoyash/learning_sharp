using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cylindre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double V;
            string S, h;

            S = textBox1.Text;
            h = textBox2.Text;

            V = Convert.ToDouble(S) * Convert.ToDouble(h);

            label1.Text = Convert.ToString(V);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Прiвет, начинай! Убери через шо будеш числити (якi величини вiдомi)...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Тобi мае бути вiдома площа i висота";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Тобi мае бути вiдомий радiус i висота";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double V, Pi = 3.141592;
            string h, R;

            R = textBox3.Text;
            h = textBox4.Text;

            V = Pi * Convert.ToDouble(R) * Convert.ToDouble(R) * Convert.ToDouble(h);

            label1.Text = Convert.ToString(V);
        }
    }
}

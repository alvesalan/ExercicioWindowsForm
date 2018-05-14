using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista1Ex1 listaex1 = new Lista1Ex1();
            listaex1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista1Ex2 listaex2 = new Lista1Ex2();
            listaex2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lista1Ex3 listaex3 = new Lista1Ex3();
            listaex3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lista1Ex4 listaex4 = new Lista1Ex4();
            listaex4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lista1Ex5 lista1ex5 = new Lista1Ex5();
            lista1ex5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lista1Ex6 lista1ex6 = new Lista1Ex6();
            lista1ex6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lista1Ex7 lista1ex7 = new Lista1Ex7();
            lista1ex7.Show();
        }
    }
}

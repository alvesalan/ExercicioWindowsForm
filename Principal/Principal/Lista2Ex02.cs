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
    public partial class Lista2Ex02 : Form
    {
        public Lista2Ex02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 0;
            txt_Numero.Focus();
            try
            {
                N = Convert.ToInt32(txt_Numero.Text);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite apenas numeros !!");
                return;
            }
           

            if (N == 0)
            {
                MessageBox.Show("O numero " + N + " é neutro");
            }
            else if (N > 0)
            {
                MessageBox.Show("O numero " + N + " não e negativo");
            }
            else if (N < 0)
            {
                MessageBox.Show("O numero " + N + " é negativo");
            }
        }
    }
}

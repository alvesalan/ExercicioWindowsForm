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
    public partial class Lista1Ex1 : Form
    {
        public Lista1Ex1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sucesso = 0;
            try
            {
                Sucesso = Convert.ToInt32(txt_numero.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("PorFavor digite apenas numeros !!");
                return;
            }

            MessageBox.Show("Sucessor: " + (Sucesso + 1));
        }

        private void btn_Antecessor_Click(object sender, EventArgs e)
        {
            int Sucesso = Convert.ToInt32(txt_numero.Text);
            MessageBox.Show("Sucessor: " + (Sucesso - 1));
        }
    }
}

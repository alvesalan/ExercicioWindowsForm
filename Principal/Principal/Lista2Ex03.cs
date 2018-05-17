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
    public partial class Lista2Ex03 : Form
    {
        public Lista2Ex03()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Opcao_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                double Numero1 = Convert.ToDouble(txt_Numero1.Text);
                txt_Numero1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite apenas numeros validos");
                return;
            }
            
            double Numero2 = Convert.ToDouble(txt_Numero2.Text);

            int Opcao = Convert.ToInt32(txt_Opcao.Text);

            
        }
    }
}

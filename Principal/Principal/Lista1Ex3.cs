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
    public partial class Lista1Ex3 : Form
    {
       
        public Lista1Ex3()
        {
            InitializeComponent();
        }

        private void Lista1Ex3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txt_N1.Text);
            double N2 = Convert.ToDouble(txt_N2.Text);
            MessageBox.Show("A soma dos numeros é: "+ N1 + "  + " + N2 + " = " + (N1 + N2));




        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txt_N1.Text);
            double N2 = Convert.ToDouble(txt_N2.Text);
            MessageBox.Show("A subtração dos numeros é: " + N1 + "  - " + N2 + " = " + (N1 - N2));
        }

        private void btn_Multiplicação_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txt_N1.Text);
            double N2 = Convert.ToDouble(txt_N2.Text);
            MessageBox.Show("A multiplicação dos numeros é: " + N1 + "  * " + N2 + " = " + (N1 * N2));
        }

        private void btn_Divisão_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txt_N1.Text);
            double N2 = Convert.ToDouble(txt_N2.Text);
            MessageBox.Show("A divisão dos numeros é: " + N1 + "  / " + N2 + " = " + (N1 / N2));
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txt_N1.Text);
            double N2 = Convert.ToDouble(txt_N2.Text);
            string Resultado = string.Format(@"A subtração dos numeros é" + 
                N1 + "  - " + N2 + " = " + (N1 - N2) +
                "A subtração dos numeros é " + 
                N1 + "  - " + N2 + " = " + (N1 - N2) + 
                "A multiplicação dos numeros é" + 
                N1 + "  * " + N2 + " = " + (N1 * N2) +
                "A divisão dos numeros é" + 
                N1 + "  / " + N2 + " = " + (N1 / N2));
            txt_Resultado.Text = Resultado;
            
        }
    }
}

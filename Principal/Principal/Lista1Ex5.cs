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
    public partial class Lista1Ex5 : Form
    {
        public Lista1Ex5()
        {
            InitializeComponent();
        }

        private void Lista1Ex5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            string NomeCarro = txt_NomeCarro.Text;
            string RNome = string.Format(NomeCarro);
            textBox5.Text = RNome;


            string Valor = string.Format(txt_ValorCarro.Text);
            textBox6.Text = Valor;

            string VCParcela = string.Format(txt_ValorCadaParcela.Text);
            textBox7.Text = VCParcela;

            string Qtd = string.Format(txt_QTD.Text);
            textBox8.Text = Qtd;

            double ValorCadaParcela = Convert.ToDouble(txt_ValorCadaParcela.Text);
            int Qtde = Convert.ToInt32(txt_QTD.Text);
            double R = ValorCadaParcela * Qtde;
            string ValorTotal = string.Format("" + R);
            textBox9.Text = ValorTotal;

            double ValorCarro = Convert.ToDouble(txt_ValorCarro.Text);
            double Diferença = ValorCarro - R;
            string DD = string.Format("Valor Carro " + ValorCarro + " - Valor total do financiamento " + R + " = Diferença de " + Diferença);
            textBox10.Text = DD;
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

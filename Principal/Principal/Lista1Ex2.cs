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
    public partial class Lista1Ex2 : Form
    {
        

        public Lista1Ex2()
        {
            InitializeComponent();
        }

        private void btn_QuantidadeLitrosConsumidos_Click(object sender, EventArgs e)
        {
            int qtdAnos = 0;
            int qtdLitros = 0;
            try
            {
               qtdLitros = Convert.ToInt32(txt_QuantidadeLitros.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }


            try
            {
                qtdAnos = Convert.ToInt32(txt_AnosConsumidos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }
            

            MessageBox.Show(string.Format("Total de Litros consumidos: " + (qtdAnos * qtdLitros)));
        }

        private void btn_ValorTotalPago_Click(object sender, EventArgs e)
        {
            int qtdAnos = 0;
            int qtdLitros = 0;
            try
            {
                qtdLitros = Convert.ToInt32(txt_QuantidadeLitros.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }


            try
            {
                qtdAnos = Convert.ToInt32(txt_AnosConsumidos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }


           double Valor = Convert.ToDouble(mtb_Valor.Text);
           double ValorTotal = qtdAnos * qtdLitros;
           double Resultado = ValorTotal * Valor;

            MessageBox.Show(string.Format("Valor total pago: " + Resultado));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double QTD = 0;
            double AnosConsumidos = 0;
            double ValorPorLitro = 0;

            try
            {
                QTD = Convert.ToDouble(txt_QuantidadeLitros.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }


            try
            {

            AnosConsumidos = Convert.ToDouble(txt_AnosConsumidos.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("PorFavor digite apenas numeros");
                return;
            }


            
            ValorPorLitro = Convert.ToDouble(mtb_Valor.Text);
           
           

            string Resultado = string.Format(@"Quantidades de litros totais consumidos: " + QTD * AnosConsumidos +
                "Valor total pago: " + QTD * AnosConsumidos * ValorPorLitro);
            txt_Resultado.Text = Resultado;
        }

        private void txt_QuantidadeLitros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

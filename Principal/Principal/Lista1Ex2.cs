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
            int qtdLitros = Convert.ToInt32(txt_QuantidadeLitros.Text);
            int qtdAnos = Convert.ToInt32(txt_AnosConsumidos.Text);

            MessageBox.Show(string.Format("Total de Litros consumidos: " + (qtdAnos * qtdLitros)));
        }

        private void btn_ValorTotalPago_Click(object sender, EventArgs e)
        {
            int qtdLitros = Convert.ToInt32(txt_QuantidadeLitros.Text);
            int qtdAnos = Convert.ToInt32(txt_AnosConsumidos.Text);
           double Valor = Convert.ToDouble(mtb_Valor.Text);
           double ValorTotal = qtdAnos * qtdLitros;
           double Resultado = ValorTotal * Valor;

            MessageBox.Show(string.Format("Valor total pago: " + Resultado));

        }
    }
}

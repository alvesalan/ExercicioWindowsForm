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
    public partial class Lista1Ex911 : Form
    {
        public Lista1Ex911()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void mtb_DataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            string texto = mtb_DataNascimento.Text;
            string[] numeros = texto.Split('/');


            int ano = Convert.ToInt32(numeros[2]);
            int quantidadeDiasVivos = (2018 - ano) * 365;
            int quantidadeAnosVivo = (2018 - ano);


            string DiasVivo = "" +quantidadeDiasVivos;
            string AnosVivos = "" + (2018 - ano);
            string MesesVivos = "" + (quantidadeAnosVivo * 8760);
            string HorasVivas = "" + (quantidadeAnosVivo * 24);
            string MinutosVivos = "" + (quantidadeAnosVivo * 525600);
            string SegundosVivos = "" + (quantidadeAnosVivo * 31536000);

            lb_DiasVivos.Text = DiasVivo;
            lb_AnosVivos.Text = AnosVivos;
            lb_MesesVivos.Text = MesesVivos;
            lb_HorasVivas.Text = HorasVivas;
            lb_MinutosVivos.Text = MinutosVivos;
            lb_SegundosVivos.Text = SegundosVivos;
            
            
        }
    }
}

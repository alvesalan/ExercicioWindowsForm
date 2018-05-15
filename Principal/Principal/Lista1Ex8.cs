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
    public partial class Lista1Ex8 : Form
    {
        public Lista1Ex8()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            

           
                double ContaLuz = Convert.ToDouble(mtb_Luz.Text);
                double ContaAgua = Convert.ToDouble(mtb_Agua.Text);
                double ContaNet = Convert.ToDouble(mtb_Net.Text);
                double ContaOi = Convert.ToDouble(mtb_Oi.Text);
                double ContaVivo = Convert.ToDouble(mtb_Vivo.Text);
                double ContaIPTU = Convert.ToDouble(mtb_IPTU.Text);
                double ContaIPVA = Convert.ToDouble(mtb_IPVA.Text);
                double SCarro = Convert.ToDouble(mtb_SCarro.Text);
           
            

            double TotalContaTelefone = (ContaOi + ContaVivo);
            double TotalImposto = (ContaIPVA + ContaIPTU);
            double Total = (ContaLuz + ContaAgua + ContaNet + ContaOi + ContaVivo + ContaIPTU + ContaIPVA + SCarro);
            double TotalR = (ContaLuz + ContaAgua + ContaNet + SCarro);

            
            txt_TContaTelefone.Text = Convert.ToString(TotalContaTelefone);

            txt_TImposto.Text = Convert.ToString(TotalImposto);
         
            txt_TRestante.Text = Convert.ToString(TotalR);

            txt_Total.Text = Convert.ToString(Total);
        }

        private void mtb_Luz_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

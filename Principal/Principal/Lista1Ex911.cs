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

            string Texto = (mtb_DataNascimento.Text);
            string[] Numeros = Texto.Split('/');

           

            
        }
    }
}

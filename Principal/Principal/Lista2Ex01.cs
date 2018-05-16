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
    public partial class Lista2Ex01 : Form
    {
        public Lista2Ex01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
           int Numero = Convert.ToInt32(txt_Numero.Text);
           txt_Numero.Focus();

           if (Numero == 0)
           {
               lb_Resultado.Text = "Neutro";
           }
           else if (Numero > 0)
           {
               lb_Resultado.Text = "Positivo";
           }
           else if (Numero < 0)
           {
               lb_Resultado.Text = "Não e Positivo";
           }
        }
    }
}

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
    public partial class Lista1Ex4 : Form
    {
        public Lista1Ex4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_Tabuada_Click(object sender, EventArgs e)
        {
             
            int Numero = Convert.ToInt32(txt_Numero.Text);
            int S1 = Numero * 1;
            int S2 = Numero * 2;
            int S3 = Numero * 3;
            int S4 = Numero * 4;
            int S5 = Numero * 5;
            int S6 = Numero * 6;
            int S7 = Numero * 7;
            int S8 = Numero * 8;
            int S9 = Numero * 9;
            int S10 = Numero * 10;
            string Resultado = string.Format(@" 
{0} * 1 = {1}
{0} * 2 = {2}
{0} * 3 = {3}
{0} * 4 = {4}
{0} * 5 = {5}
{0} * 6 = {6}
{0} * 7 = {7}
{0} * 8 = {8}
{0} * 9 = {9}
{0} * 10 = {10}", Numero, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10);
                  
                txt_Final.Text = Resultado;
                
               
            
        }

        private void txt_Final_TextChanged(object sender, EventArgs e)
        {
            

            
           
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

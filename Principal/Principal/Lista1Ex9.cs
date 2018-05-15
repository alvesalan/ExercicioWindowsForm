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
    public partial class Lista1Ex09 : Form
    {
        public Lista1Ex09()
        {
            InitializeComponent();
        }

        private void Lista1Ex09_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            int n1 = Convert.ToInt32(txt_N1.Text);
            int f = Convert.ToInt32(n1);

            if (e.KeyCode == Keys.Enter)
            {
                lb_N1.Text = Convert.ToString(f);
            }
        }

        private void txt_N2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_N2.Text = Convert.ToString(txt_N1.Text);
            }
        }

        private void txt_N1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

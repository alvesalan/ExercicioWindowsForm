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
    public partial class Lista1Ex6 : Form
    {
        public Lista1Ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(mtb_N1.Text);
            double N2 = Convert.ToDouble(mtb_N2.Text);
            double N3 = Convert.ToDouble(mtb_N3.Text);
            double N4 = Convert.ToDouble(mtb_N4.Text);

            double Media = (N1 + N2 + N3 + N4) / 4;
            MessageBox.Show(string.Format("Media: {0:n}", Media));
        }
    }
}

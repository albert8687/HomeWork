using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace MyHomeWork._1002_貸款
{
    public partial class FrmLoan : Form
    {
        public FrmLoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rate = double.Parse(txt3.Text);
            double result = Financial.Pmt((rate / 100) / 12, double.Parse(txt2.Text), double.Parse(txt1.Text)) * -1;

            MessageBox.Show(result.ToString());

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double rate = double.Parse(txt3.Text);
            double result = Financial.Pmt((rate / 100) / 12, double.Parse(txt2.Text), double.Parse(txt1.Text)) * -1;
            double payment = double.Parse(txt2.Text) * result;
            MessageBox.Show(payment.ToString());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();

        }
    }
}

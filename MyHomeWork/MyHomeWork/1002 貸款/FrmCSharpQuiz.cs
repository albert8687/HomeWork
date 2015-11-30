using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork._1002_貸款
{
    public partial class FrmCSharpQuiz : Form
    {
        public FrmCSharpQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 1; i <= 99; i++)
            {
                sum += i;
            }
            MessageBox.Show("For : 1 到99的和為" + sum);

            int a = 0, sum2 = 0;
            while(a<=99)
            {
                sum2 += a;
                a++;
            }

            MessageBox.Show("While : 1 到99的和為" + sum2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] namelist = { "Albert", "Billy", "CSharp", "Clinc" };















    

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = { 44, 66, 99, 100, 78 };
            Max(nums);
            Min(nums);

        }

        void Max(int[] test)
        {
            MessageBox.Show("highest score = " + test.Max().ToString());
        }

        void Min(int[] test)
        {
            MessageBox.Show("lowest score = " + test.Min().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 44, 66, 99, 100, 78 };
            int evenum=0;
            int oddnum=0;

            foreach(int i in nums)

            if(i%2==0)
            {
                evenum++;
            }
            else
            {
                oddnum++;
            }

            MessageBox.Show("there are" + oddnum + "odd number and " + evenum +" even number");

        }
    }
}

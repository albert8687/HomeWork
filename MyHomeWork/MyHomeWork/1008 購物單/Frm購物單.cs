using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace Lab02
{
    public partial class Frm購物單 : Form
    {

        public Frm購物單()
        {
            InitializeComponent();
            panel3.BackColor = Color.FromArgb(70, Color.White);
            
        }           

        private void btnabout_Click(object sender, EventArgs e)
        {
            string result;
            Version V = Assembly.GetExecutingAssembly().GetName().Version;
            result = String.Format("Version {0}-{1}-{2}-{3}", 
                                              V.Major, V.Minor, V.MajorRevision, V.Revision);
            MessageBox.Show("McDonald Co. Ltd " + result);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
             chkall.Checked = false;
            chkbox1.Checked = false;
            chkbox2.Checked = false;
            chkbox3.Checked = false;
            chkbox4.Checked = false;

            this.txttotal.Text = "0";
            this.txtamt1.Text = "0";
            this.txtamt2.Text = "0";
            this.txtamt3.Text = "0";
            this.txtamt4.Text = "0";

            radcard.Checked = false;
            radcash.Checked = false;
            radcheck.Checked = false;

            this.textBox1.Text = "";
            this.txtchange.Text = "0";
            this.txtpaid.Text = "0";
            this.txtinfo.Text = "";
            return;



        }
        int a, b, c, d; 
        
        

        private void chkbox1_CheckedChanged(object sender, EventArgs e)

        {
 
            if (chkbox1.Checked == true)
            {
                this.txtamt1.Enabled = true;
            }
            else 
            {   
                a = 0;
            }
            this.txttotal.Text = (a + b + c + d).ToString();
        }
       

        private void chkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox2.Checked == true)
            {

                this.txtamt2.Enabled = true;
            }
            else
            {
                b = 0;
            }
            this.txttotal.Text = (a + b + c + d).ToString();
        }

        private void chkbox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox3.Checked == true)
            {

                this.txtamt3.Enabled = true;
            }
            else
            {
                c = 0;
            }
            this.txttotal.Text = (a + b + c + d).ToString();
        }

        private void chkbox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox4.Checked == true)
            {

                this.txtamt4.Enabled = true;
                
            }
            else
            {
                d = 0;
            }
            
            this.txttotal.Text = (a + b + c + d).ToString();
 
        }
        
        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            if(chkall.Checked == true)
            {
                chkbox1.Checked = true;
                chkbox2.Checked = true;
                chkbox3.Checked = true;
                chkbox4.Checked = true;
                this.txttotal.Text = (a + b+ c + d).ToString();
                this.textBox1.Text = ("You Have Chosed " + txtamt1.Text + " Big Mac.\r\n" +
                        "You Have Chosed " + txtamt2.Text + " McFish.\r\n" +
                       "You Have Chosed " + txtamt3.Text + " McChicken.\r\n" +
                       "You Have Chosed " + txtamt4.Text + " Mcnuggets.\r\n");
            }
            else
            {
                chkbox1.Checked = false;
                chkbox2.Checked = false;
                chkbox3.Checked = false;
                chkbox4.Checked = false;

            }
        }
        

        private void Frm購物單_Load(object sender, EventArgs e)
        {
        }

        private void panelfood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm購物單_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        

        void check_format(TextBox test)
        {
            try
            {
                a = 79 * int.Parse(this.txtamt1.Text);
                d = 49 * int.Parse(this.txtamt4.Text);
                b = 39 * int.Parse(this.txtamt2.Text);
                c = 39 * int.Parse(this.txtamt3.Text);
                this.txttotal.Text = (a + b + c + d).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("發生" + error.Message + "請輸入數字!!!");
                test.Text = "0";
            }

        }
        private void txtamt1_TextChanged(object sender, EventArgs e)
        {

            check_format(txtamt1);
            this.textBox1.Text = "You Have Chosed " + txtamt1.Text + " Big Mac.\r\n" +
                     "You Have Chosed " + txtamt2.Text + " McFish.\r\n" +
                     "You Have Chosed " + txtamt3.Text + " McChicken.\r\n" +
                     "You Have Chosed " + txtamt4.Text + " Mcnuggets.\r\n";
        }

        private void txtamt2_TextChanged(object sender, EventArgs e)
        {
            check_format(txtamt2);
            this.textBox1.Text = "You Have Chosed " + txtamt1.Text + " Big Mac.\r\n" +
                     "You Have Chosed " + txtamt2.Text + " McFish.\r\n" +
                     "You Have Chosed " + txtamt3.Text + " McChicken.\r\n" +
                     "You Have Chosed " + txtamt4.Text + " Mcnuggets.\r\n";
        }

        private void txtamt3_TextChanged(object sender, EventArgs e)
        {
            check_format(txtamt3);
            this.textBox1.Text = "You Have Chosed " + txtamt1.Text + " Big Mac.\r\n" +
                     "You Have Chosed " + txtamt2.Text + " McFish.\r\n" +
                     "You Have Chosed " + txtamt3.Text + " McChicken.\r\n" +
                     "You Have Chosed " + txtamt4.Text + " Mcnuggets.\r\n";
        }

        private void txtamt4_TextChanged(object sender, EventArgs e)
        {
            check_format(txtamt4);
            this.textBox1.Text = "You Have Chosed " + txtamt1.Text + " Big Mac.\r\n" +
                     "You Have Chosed " + txtamt2.Text + " McFish.\r\n" +
                     "You Have Chosed " + txtamt3.Text + " McChicken.\r\n" +
                     "You Have Chosed " + txtamt4.Text + " Mcnuggets.\r\n";
        }

        private void radcard_CheckedChanged(object sender, EventArgs e)
        {
            if (radcard.Checked == true)
            {

                MessageBox.Show("You Want To Pay By Card.");
                   
            }
        }

        private void radcash_CheckedChanged(object sender, EventArgs e)
        {
            if (radcash.Checked == true)
            {

                MessageBox.Show("You Want To Pay By Cash.");


            }
        }

        private void radcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radcheck.Checked == true)
            {

                MessageBox.Show("You Want To Pay By Check, God Damn.");
            
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://itunes.apple.com/us/app/mcdonalds/id922103212?mt=8");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.panel3.Width = this.ClientSize.Width;
            this.panel3.Height = this.ClientSize.Height;
            this.Close();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            int paid, total, change;
            paid = int.Parse(txtpaid.Text);
            total = int.Parse(txttotal.Text);
            change = paid - total;
            txtchange.Text = change.ToString();


            int a, b, c, d, f,g;
            a = b = c = d = f  = g = 0;

            if (change < 0)
            {
                MessageBox.Show("您還需要多付" + Math.Abs(change) + "元才行喔"); 
            }
            if (change > 1000)
            {
                a = change / 1000;
                change = change % 1000;
            }
            if (change > 500)
            {
                b = change / 500;
                change = change % 500;
            }
            if (change > 100)
            {
                c = change / 100;
                change = change % 100;
            }
            if (change > 50)
            {
                d = change / 50;
                change = change % 50;
            }
            if (change > 10)
            {
                f = change / 10;
                change = change % 10;
            }
            if (change > 1)
            {
                g = change / 1;
                change = change % 1;
            }
            this.txtinfo.Text = ("找您零錢1000元" + a.ToString() + "張\r\n"  + 
                                 "找您零錢500元"  + b.ToString() + "張\r\n"  + 
                                 "找您零錢100元"  + c.ToString() + "張\r\n"  +
                                 "找您零錢50元"   + d.ToString() + "枚\r\n"  +
                                 "找您零錢10元"   + f.ToString() + "枚\r\n"  + 
                                 "找您零錢5 元"   + g.ToString() + "枚\r\n"  );

        
            
        }
        
        
        
    }
}

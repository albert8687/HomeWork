using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();

            
           
           
            foreach (Control x in this.Controls)
            { 
                if (x!=button1)
                {
                x.Click += x_Click;
                x.Click += x_check;
                this.Font = new Font("Arial", 10, FontStyle.Bold);
                }
            }
        }

        private bool change = true;
        private void FrmGame_Click(object sender, EventArgs e)
        {
            
           

        }

        void x_Click(object sender , EventArgs e)
        {
            if (change)
            {
                ((Button)sender).Text = "O";
                ((Button)sender).Enabled = false; 
            }
            else 
            {
                ((Button)sender).Text = "X";
                ((Button)sender).Enabled = false;
            }

            change = !change;
        }

        private void x_check(object sender , EventArgs e)
        {
        if
            (
                (b1.Text == "O" && b2.Text == "O" && b3.Text == "O") ||
                (b4.Text == "O" && b5.Text == "O" && b6.Text == "O") ||
                (b7.Text == "O" && b8.Text == "O" && b9.Text == "O") ||
                (b1.Text == "O" && b4.Text == "O" && b7.Text == "O") ||
                (b2.Text == "O" && b5.Text == "O" && b8.Text == "O") ||
                (b3.Text == "O" && b6.Text == "O" && b9.Text == "O") ||
                (b1.Text == "O" && b5.Text == "O" && b9.Text == "O") ||
                (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
            )
                {
                MessageBox.Show("OO 贏囉");
                
                }


            if
            (
                (b1.Text == "X" && b2.Text == "X" && b3.Text == "X") ||
                (b4.Text == "X" && b5.Text == "X" && b6.Text == "X") ||
                (b7.Text == "X" && b8.Text == "X" && b9.Text == "X") ||
                (b1.Text == "X" && b4.Text == "X" && b7.Text == "X") ||
                (b2.Text == "X" && b5.Text == "X" && b8.Text == "X") ||
                (b3.Text == "X" && b6.Text == "X" && b9.Text == "X") ||
                (b1.Text == "X" && b5.Text == "X" && b9.Text == "X") ||
                (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            )
                {
                MessageBox.Show("XX 贏囉");
                
                }

            if
           (
               (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false &&
               b4.Enabled == false && b5.Enabled == false && b6.Enabled == false &&
               b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)


          )
                { 
                MessageBox.Show("平手ㄟ");
                
                }


           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            b1.Text = ""; b2.Text = ""; b3.Text = "";
            b4.Text = ""; b5.Text = ""; b6.Text = "";
            b7.Text = ""; b8.Text = ""; b9.Text = "";

            b1.Enabled = true; b2.Enabled = true; b3.Enabled = true;
            b4.Enabled = true; b5.Enabled = true; b6.Enabled = true;
            b7.Enabled = true; b8.Enabled = true; b9.Enabled = true;


        }
        
         
    }
            
}

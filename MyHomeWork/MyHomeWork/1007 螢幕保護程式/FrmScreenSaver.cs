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
    public partial class FrmScreenSaver : Form
    {
        public FrmScreenSaver()
        {
            InitializeComponent();
            this.MouseMove += FrmScreenSaver_MouseMove;
        }

        private int nx = Cursor.Position.X;
        private int ny = Cursor.Position.Y;

        private void FrmScreenSaver_MouseMove(object sender, EventArgs e)
        {
            int mx = MousePosition.X;
            int my = MousePosition.Y;
            int result;

            result = (((mx - nx) ^ 2 + (my - ny) ^ 2)) ^ (1 / 2);

            if (result > 123)
            {
                this.Close();
            
            }
            //string x, y;
            //x = (Cursor.Position.X).ToString();
            //y = (Cursor.Position.Y).ToString();



            //if ((Cursor.Position.X).ToString() != x || (Cursor.Position.Y).ToString() != y)
            //{
            //    this.Close();
            //}

        }
       
        private void FrmScreenSaver_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("yyyy/MM/dd, hh:mm:ss");
            this.label1.Left += 7;
            
            if (this.label1.Right > 1370)
            {

                timer2.Enabled = true;
                timer1.Enabled = false;
            }
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            this.label1.Left -= 7;


            if (this.label1.Left < 3)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void FrmScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        }
    }       
            


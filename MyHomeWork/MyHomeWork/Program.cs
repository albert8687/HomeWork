﻿using Lab02;
using MyHomeWork._1002_貸款;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLoan()); 
            //Application.Run(new FrmCSharpQuiz());
            Application.Run(new Frm購物單());

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixLogic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Helper.initBase();
            if (Helper.database.ExistManager() == false)
            {
                Helper.database.AddManager("admin", "admin", "admin", "0000000000", "admin");
            }
            Helper.createUserSelectOnly();
            Helper.help();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow.START = true;
            MainWindow fen = new MainWindow();

            fen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(fen);
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }
    }
}

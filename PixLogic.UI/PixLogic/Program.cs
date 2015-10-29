using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FenetrePrincipale fen = new FenetrePrincipale();
            fen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(fen);
        }
    }
}

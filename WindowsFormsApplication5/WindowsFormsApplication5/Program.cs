using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    static class Program
    {
        
        // se declara variable de forma principal
        public static frmSoftj frmSoftj;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instancio la variable del formulario
            frmSoftj = new frmSoftj();
            
            // Lo mando correr
            Application.Run(frmSoftj);
        }
    }
}

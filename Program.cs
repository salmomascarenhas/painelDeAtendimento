using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painel_Pacientes.Classes;
using Painel_Pacientes.Forms;

namespace Painel_Pacientes
{
    static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        ///         
        [STAThread]
        static void Main()
        {

          Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

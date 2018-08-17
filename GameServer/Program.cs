using GameServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer
{

    public static class Program
    {
        public static Server _serverInstance;
        public static formServer _formInstance;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _formInstance = new formServer();
            Application.Run(_formInstance);
        }
    }
}

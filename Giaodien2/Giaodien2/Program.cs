using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien2
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
            Application.Run(new Frm_MaHoaDX());
            //Application.Run(new frm_giaimadx());
            //Application.Run(new Frm_FormMain());
            //Application.Run(new frm_mahoarsa());
            //Application.Run(new frm_giaimarsa());
            //Application.Run(new frm_createkey());
            //Application.Run(new frm_Login());
            //Application.Run(new frm_Update());
            //Application.Run(new frm_Registration());
            //Application.Run(new frm_Adminform());
            //Application.Run(new frm_Adminlogin());
        }
    }
}

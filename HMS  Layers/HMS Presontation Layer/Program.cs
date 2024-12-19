using HMS_Presontation_Layer.Guests;
using HMS_Presontation_Layer.Login;
using HMS_Presontation_Layer.Payments;
using HMS_Presontation_Layer.Rooms;
using HMS_Presontation_Layer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

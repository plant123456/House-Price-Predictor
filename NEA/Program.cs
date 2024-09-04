using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NEA
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
            Application.Run(new MainMenu());

          

            connection.Open();
        }

        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4FCU0KI\SQLEXPRESS;Initial Catalog = NEAdatabase1; Integrated Security = True");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureTest
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public String ConnectionAzure = @"Server=tcp:socialwire2.database.windows.net,1433;Initial Catalog=AtClipping;Persist Security Info=False;User ID=sw_user;Password=Miraiz777;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        static public String ConnectionLocal = @"Data Source=(local);Initial Catalog=AtClipping;User Id=sa;Password=superuser;";

    }


}

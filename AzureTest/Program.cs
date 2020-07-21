using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureTableTool
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

        //        static public String ConnectionAzure = @"Server=tcp:socialwire.database.windows.net,1433;Initial Catalog=AtClipping;Persist Security Info=False;User ID=sw_user;Password=Miraiz777;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        static public String ConnectionAzure = @"Server=tcp:socialwirenet.database.windows.net,1433;Initial Catalog = AtClipping; Persist Security Info=False;User ID = sw_user; Password=Miraiz777; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        static public String ConnectionLocal = @"Data Source=(local);Initial Catalog=AtClipping;User Id=sa;Password=superuser;";
        //        static public String ConnectionLocal = @"Data Source = 192.168.1.6\AXELE_INSTANCE;Initial Catalog = AtClipping; User Id = sw_user; Password=miraiz;";

    }


}

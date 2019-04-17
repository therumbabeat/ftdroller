using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;

namespace FtDRoller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserCredential userCredential = GoogleSheetLoader.LoadCredential();
            String sheetUrl = "https://docs.google.com/spreadsheets/d/1I2N-YZsuKupQ-avOSoayw4VLLyd8OsxVFlSn5sOFf1c/edit#gid=790763898";
            GoogleSheetLoader loader = new GoogleSheetLoader(sheetUrl, userCredential);
            IList<IList<object>> rows = loader.GetSheetRows();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
        }
    }
}

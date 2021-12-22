using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace ReservProgram
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
/*            CultureInfo culture = CultureInfo.CreateSpecificCulture("ko");

            Thread.CurrentThread.CurrentUICulture = culture;

            Thread.CurrentThread.CurrentCulture = culture;

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;*/            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("ko");

            Application.Run(new MainForm());


        }

    }
    
}
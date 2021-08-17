using Pcomm32Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroTensileTester
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var device = PMAC.PmacSelect(0);

            //if (PMAC.OpenPmacDevice(device) == 0)
            //{
            //    MessageBox.Show("장치가 OPEN되지 않았습니다..", "에러");
            //    return;
            //}

            //Application.Run(new MainForm(device));
            Application.Run(new MainForm(0));
        }
    }
}

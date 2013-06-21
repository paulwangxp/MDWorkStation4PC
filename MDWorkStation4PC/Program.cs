using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MDWorkStation4PC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if (checkExpireDate.isExpire())
            //{
            //    MessageBox.Show("试用版本期限已到，请联系相关人员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            Application.Run(new Form1());
        }
    }
}

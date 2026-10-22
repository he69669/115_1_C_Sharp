using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test_Average
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows Forms 的視覺樣式。
            Application.EnableVisualStyles();
            // 使用與目前應用程式相容的文字呈現方式。
            Application.SetCompatibleTextRenderingDefault(false);
            // 建立並顯示主表單。
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Change_Counter
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
            // 設定控制項使用預設的文字轉譯方式。
            Application.SetCompatibleTextRenderingDefault(false);
            // 啟動零錢計算器主表單。
            Application.Run(new Form1());
        }
    }
}

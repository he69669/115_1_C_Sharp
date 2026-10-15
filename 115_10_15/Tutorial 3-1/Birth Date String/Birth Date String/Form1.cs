using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件與介面配置。
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 依照星期、月份、日期與年份的順序組合出生日期字串。
            string output;

            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + "" + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            // 將組合完成的日期顯示在結果標籤中。
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入欄位的內容。
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // 清除日期結果。
            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void dateOutputLabel_Click(object sender, EventArgs e)
        {
            // 日期結果標籤目前不需要執行任何動作。
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有控制項。
        public Form1()
        {
            InitializeComponent();
        }

        // 計算三次測驗成績的平均值。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三次測驗成績與平均值變數。
            double test1, test2, test3, average;

            try
            {
                test1 = double.Parse(test1TextBox.Text); // 取得第一次測驗成績。
                test2 = double.Parse(test2TextBox.Text); // 取得第二次測驗
                test3 = double.Parse(test3TextBox.Text); // 取得第三次測驗成績。

                average = (test1 + test2 + test3) / 3; // 計算平均值。

                averageLabel.Text = average.ToString("F1"); // 將平均值顯示在標籤上，並格式化為小數點後一位。

            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");// 顯示錯誤訊息，提示使用者輸入有效的數字。
            }
        }

        // 清除所有輸入的成績與計算結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入欄位與平均分數顯示欄位。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        // 關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

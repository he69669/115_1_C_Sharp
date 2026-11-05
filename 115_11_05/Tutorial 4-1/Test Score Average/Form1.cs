using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        /// <summary>
        ///按下「計算平均,按紐時執行。
        /// </summary>


        private void calculateButton_Click(object sender, EventArgs e)

        {
            // 高分門常數(目前保留供後續遲輯使用)。
            // const double HIGH_SCORE = 95.0;

            const double PASSING_SCORE = 60.0; //及格分數常數。

            //宣告三次測驗成績與平均分數變數。
            double test1, test2, test3, average;
            string grade;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 按下計算按鈕後，執行平均分數計算。
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個分數輸入框及平均分數顯示內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將游標移回第一個分數輸入框。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void test1promptLabel_Click(object sender, EventArgs e)
        {
            // 第一個分數提示標籤不需要額外處理。
        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
            // 第一個分數輸入內容變更時不需要額外處理。
        }

        private void averageLabel_Click(object sender, EventArgs e)
        {
            // 平均分數標籤不需要額外處理。
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

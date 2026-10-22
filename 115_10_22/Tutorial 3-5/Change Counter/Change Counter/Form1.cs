using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTY_FIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;
        private decimal total = 0.00m; // 初始化總金額為零。
        // 建立零錢計算器表單。
        public Form1()
        {
            InitializeComponent();
        }

        // 處理五分硬幣圖片的點擊事件。
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
           // decimal total =0.00m;// 初始化總金額為零。
            total =total+ FIVE_CENTS;// 將五硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C");// 將總金額格式化為貨幣格式並顯示在 totalLabel 上。
        }

        // 處理一角硬幣圖片的點擊事件。
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
          // decimal total = 0.00m;// 初始化總金額為零。
            total = total + TEN_CENTS;// 將一角硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C");// 將總金額格式化為貨幣格式並顯示在 totalLabel 上。
        }

        // 處理二角五分硬幣圖片的點擊事件。
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + TWENTY_FIVE_CENTS;// 將二角五分硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C");// 將總金額格式化為貨幣格式並顯示在 totalLabel 上。
        }

        // 處理五角硬幣圖片的點擊事件。
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
           total = total + FIFTY_CENTS;// 將五角硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C");// 將總金額格式化為貨幣格式並顯示在 totalLabel 上。
        }

        // 關閉零錢計算器視窗。
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

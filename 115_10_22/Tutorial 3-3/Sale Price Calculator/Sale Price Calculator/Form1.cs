using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單及其控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            decimal originalPrice;// 儲存使用者輸入的商品原價。
            decimal discountPercentage;// 儲存使用者輸入的折扣百分比。
            decimal discountPrice;// 儲存計算出的折扣金額。

            originalPrice=decimal.Parse(originalPriceTextBox.Text);// 取得使用者輸入的商品原價。
            discountPercentage=decimal.Parse(discountPercentageTextBox.Text);// 取得使用者輸入的折扣百分比。
            discountPrice = originalPrice * (discountPercentage / 100);// 計算折扣金額。
            decimal salePrice = originalPrice - discountPrice;// 計算折扣後的價格。

            salePriceLabel.Text = salePrice.ToString("C");// 將計算出的折扣後價格顯示在標籤上，並格式化為貨幣格式。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}

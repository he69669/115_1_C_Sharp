using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;// 宣告變數以儲存行駛的公里數。
            double liters;// 宣告變數以儲存使用的汽油公升數。
            double kmpl;// 宣告變數以儲存每公升汽油行駛的公里數。

            km = double.Parse(kmTextBox.Text);// 取得使用者輸入的公里數。
            liters = double.Parse(literTextBox.Text);// 取得使用者輸入的汽油公升數。
            kmpl = km / liters;// 計算每公升汽油行駛的公里數。

            kmplLabel.Text = kmpl.ToString("F2")+"公里/公升";// 顯示結果，並格式化為小數點後兩位。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

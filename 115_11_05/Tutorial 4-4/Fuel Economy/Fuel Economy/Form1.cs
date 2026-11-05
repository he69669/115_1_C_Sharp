using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            double km; // 儲存行駛距離（公里）
            double liters; // 儲存使用汽油量（公升）
            double kmpl; // 儲存每公升行駛公里數

            km = double.Parse(kmTextBox.Text); // 取得使用者輸入的公里數
            liters = double.Parse(literTextBox.Text); // 取得使用者輸入的公里數和汽油量
            if (double.TryParse(kmTextBox.Text, out km))
            {
                if (double.TryParse(literTextBox.Text, out liters))
                {
                    if (km > 0 && liters > 0)
                    {

                        kmpl = km / liters; // 計算每公升行駛公里數
                        kmplLabel.Text = kmpl.ToString("F2") + "公里/公升";
                    }
                    else
                    {
                        MessageBox.Show("請輸入有效的汽油量。");
                    }
                    }
                    else
                    {
                        MessageBox.Show("請輸入有效的汽油量。");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的行駛公里數。");

                }

                kmpl = km / liters; // 計算每公升行駛公里數
                kmplLabel.Text = kmpl.ToString("F2") + "公里/公升";
            }
        }
        


        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉程式
            this.Close();
        }
    }
}
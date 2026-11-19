using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // TODO 1：每次試算時，將三個結果欄位重設為「—」
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                // TODO 2：用 if-else 檢查天數是否在 1~7 天內（含首尾）
                if (days >= 1 && days <= 7)
                {
                    int dailyRate = 0;
                    int discount = 0;
                    string discountText = "";

                    // TODO 3-1：用 if-else-if 決定每日費用
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    // TODO 3-2：用巢狀 if 判斷社團優惠
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            discountText = "折抵 30 元";
                        }
                        else
                        {
                            discount = 0;
                            discountText = "未達折抵門檻";
                        }
                    }
                    else
                    {
                        discount = 0;
                        discountText = "無優惠";
                    }

                    // TODO 4：計算應付金額並更新三個結果欄位
                    int total = (dailyRate * days) - discount;

                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabel.Text = discountText;
                    totalLabel.Text = total.ToString() + " 元";
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入與勾選狀態
            daysTextBox.Text = "";
            feedbackLabel.Text = "";
            clubCheckBox.Checked = false;

            // 重設三個結果欄位
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
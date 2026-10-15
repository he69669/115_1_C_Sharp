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
            double kilometers;
            double liters;

            if (!double.TryParse(milesTextBox.Text, out kilometers) || kilometers < 0 ||
                !double.TryParse(gallonsTextBox.Text, out liters) || liters <= 0)
            {
                MessageBox.Show("請輸入有效的公里數與公升數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mpgLabel.Text = (kilometers / liters).ToString("0.##") + " 公里／公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

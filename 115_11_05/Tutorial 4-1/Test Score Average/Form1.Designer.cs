namespace Test_Score_Average
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的元件容器。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則釋放受控資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.testScoreGroupBox.Location = new System.Drawing.Point(24, 24);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(592, 300);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "輸入三個測驗分數";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(55, 246);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(164, 46);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "平均分數";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.averageLabel.Location = new System.Drawing.Point(230, 238);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(300, 48);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.averageLabel.Click += new System.EventHandler(this.averageLabel_Click);
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test3promptLabel.Location = new System.Drawing.Point(55, 166);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(194, 46);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "測驗分數 3";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test2promptLabel.Location = new System.Drawing.Point(55, 111);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(194, 46);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "測驗分數 2";
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test1promptLabel.Location = new System.Drawing.Point(55, 56);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(194, 46);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "測驗分數 1";
            this.test1promptLabel.Click += new System.EventHandler(this.test1promptLabel_Click);
            // 
            // test3TextBox
            // 
            this.test3TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test3TextBox.Location = new System.Drawing.Point(266, 159);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(300, 53);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test2TextBox.Location = new System.Drawing.Point(266, 100);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(300, 53);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.test1TextBox.Location = new System.Drawing.Point(266, 49);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(300, 53);
            this.test1TextBox.TabIndex = 0;
            this.test1TextBox.TextChanged += new System.EventHandler(this.test1TextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.calculateButton.Location = new System.Drawing.Point(24, 348);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(260, 58);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "計算平均值";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.clearButton.Location = new System.Drawing.Point(306, 348);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 58);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.exitButton.Location = new System.Drawing.Point(468, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 58);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "測驗分數平均值";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


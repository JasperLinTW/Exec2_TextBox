namespace Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkButton = new System.Windows.Forms.Button();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTxtBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(78, 116);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "檢查";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(56, 83);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(116, 22);
            this.inputTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "請輸入你的生日";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(56, 154);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(116, 26);
            this.resultTxtBox.TabIndex = 3;
            this.resultTxtBox.Text = "resultTxtBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 251);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultTxtBox;
    }
}


namespace Q1
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
            this.numberTxtbox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberTxtbox
            // 
            this.numberTxtbox.Location = new System.Drawing.Point(35, 68);
            this.numberTxtbox.Name = "numberTxtbox";
            this.numberTxtbox.Size = new System.Drawing.Size(125, 22);
            this.numberTxtbox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(56, 106);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "檢查";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "請輸入一個1~99的整數";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLable.Location = new System.Drawing.Point(12, 143);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(41, 16);
            this.resultLable.TabIndex = 3;
            this.resultLable.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 186);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.numberTxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTxtbox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLable;
    }
}


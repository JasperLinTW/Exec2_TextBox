namespace Q4
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
            this.carNumTxtBx = new System.Windows.Forms.TextBox();
            this.peapleNumTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carPriceTxtBox = new System.Windows.Forms.TextBox();
            this.peoplePriceBox = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carNumTxtBx
            // 
            this.carNumTxtBx.Location = new System.Drawing.Point(52, 48);
            this.carNumTxtBx.Name = "carNumTxtBx";
            this.carNumTxtBx.Size = new System.Drawing.Size(100, 22);
            this.carNumTxtBx.TabIndex = 0;
            // 
            // peapleNumTxtBx
            // 
            this.peapleNumTxtBx.Location = new System.Drawing.Point(201, 48);
            this.peapleNumTxtBx.Name = "peapleNumTxtBx";
            this.peapleNumTxtBx.Size = new System.Drawing.Size(100, 22);
            this.peapleNumTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "以車計價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "以人計價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "汽車數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "人數";
            // 
            // carPriceTxtBox
            // 
            this.carPriceTxtBox.Location = new System.Drawing.Point(52, 152);
            this.carPriceTxtBox.Name = "carPriceTxtBox";
            this.carPriceTxtBox.Size = new System.Drawing.Size(100, 22);
            this.carPriceTxtBox.TabIndex = 7;
            // 
            // peoplePriceBox
            // 
            this.peoplePriceBox.Location = new System.Drawing.Point(201, 152);
            this.peoplePriceBox.Name = "peoplePriceBox";
            this.peoplePriceBox.Size = new System.Drawing.Size(100, 22);
            this.peoplePriceBox.TabIndex = 8;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(52, 87);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(249, 23);
            this.calButton.TabIndex = 2;
            this.calButton.Text = "計算";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLable.Location = new System.Drawing.Point(50, 186);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(76, 16);
            this.resultLable.TabIndex = 9;
            this.resultLable.Text = "resultLable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 236);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.peoplePriceBox);
            this.Controls.Add(this.carPriceTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.peapleNumTxtBx);
            this.Controls.Add(this.carNumTxtBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carNumTxtBx;
        private System.Windows.Forms.TextBox peapleNumTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carPriceTxtBox;
        private System.Windows.Forms.TextBox peoplePriceBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label resultLable;
    }
}


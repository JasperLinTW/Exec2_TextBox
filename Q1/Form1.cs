using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{/// <summary>
 /// 輸入數值是否在[1,99]
 /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLable.Text = string.Empty;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //取得數值
            int number= -1;
            try
            {
                number = GetNumber();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //判斷是否在1-99之間
            if (number >= 1 && number <= 99)
            {
                resultLable.Text = $"您輸入的{number}在1-99之間";
            }
            else
            {
                resultLable.Text = $"{number}不在1-99之間";
            }


        }

        private int GetNumber()
        {
            string input = numberTxtbox.Text;
            bool isInt = int.TryParse(input, out int number);
            return isInt ? number: throw new Exception("您輸入的數值不合規定");
        }
    }
}

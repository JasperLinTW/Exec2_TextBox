using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{/// <summary>
 /// 經由輸入生日判斷是否已滿 13 歲
 /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultTxtBox.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            DateTime input; 
            try
            {
                input = GetTime();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (DateTime.Today.Year- input.Year >= 13)
            {
                resultTxtBox.Text = $"您今年已滿13歲";
            }
            else
            {
                resultTxtBox.Text = $"您今年尚未滿13歲";
            }

        }

        private DateTime GetTime()
        {
            string txt = inputTxtBox.Text;
            bool isDateTime = DateTime.TryParse(txt, out DateTime input);
            return isDateTime ? input : throw new Exception("您輸入的日期格是錯誤");
        }
    }
}

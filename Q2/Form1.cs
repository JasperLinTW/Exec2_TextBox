using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{/// <summary>
/// 輸入日期是否不大於今天
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            string output =(input > DateTime.Today) ? "是" : "否";

            outputTxtBox.Text = output;
        }

        private DateTime GetTime()
        {
            string txt = inputTxtBox.Text;
            bool isDateTime = DateTime.TryParse(txt, out DateTime input);
            return isDateTime ? input : throw new Exception("您輸入的日期格式錯誤，正確為yyyy/MM/dd");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{/// <summary>
/// 15.50 計算入場費用
/// 入場費用計算規則:
/// 每一個團體要進入園區時,可以用比較便宜的團體, 限制是只能採
/// 取以下兩種裡的一種, 不能拆分成兩個團體
/// 按車輛計費:
/// 每部車收 200 元, 不管裡面坐多少乘客
/// 按人頭計費:
/// 每人收 60 元, 無論多少部車
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLable.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calButton_Click(object sender, EventArgs e)
        {
            const int carRate = 200;
            const int peopleRate = 60;
            int carNum = GetCarNum();
            int peopleNum = GetPeopleNum();
            int carResult = GetPrice(carNum, carRate);
            int peopleResult = GetPrice(peopleNum, peopleRate);
            carPriceTxtBox.Text = carResult.ToString();
            peoplePriceBox.Text = peopleResult.ToString();
            resultLable.Text = carResult > peopleResult ? "以人計價較便宜" : "以車計價較便宜";

        }

        private int GetPrice(int num, int rate)
        {
            return num * rate;
        }

        private int GetPeopleNum()
        {
            int peopleInput = 0;
            try
            {
                peopleInput = GetInt(peapleNumTxtBx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return peopleInput;
        }

        private int GetCarNum()
        {
            int carInput=0;
            try
            {
                carInput = GetInt(carNumTxtBx.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return carInput;
        }

        private int GetInt(string text)
        {
             bool isInt = int.TryParse(text, out int result);
             return isInt ? result : throw new Exception("您輸入的數字格式有誤)");
        }
    }
}

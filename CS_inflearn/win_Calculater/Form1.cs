using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater {
    public partial class Form1 : Form {

        enum Operators {
            None,
            Add,
            Subtract,
            Multiplay,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operratorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1() {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) {
            string strnum = display.Text += "1";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn2_Click(object sender, EventArgs e) {
            string strnum = display.Text += "2";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn3_Click(object sender, EventArgs e) {
            string strnum = display.Text += "3";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn4_Click(object sender, EventArgs e) {
            string strnum = display.Text += "4";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn5_Click(object sender, EventArgs e) {
            string strnum = display.Text += "5";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn6_Click(object sender, EventArgs e) {
            string strnum = display.Text += "6";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn7_Click(object sender, EventArgs e) {
            string strnum = display.Text += "7";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn8_Click(object sender, EventArgs e) {
            string strnum = display.Text += "8";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn9_Click(object sender, EventArgs e) {
            string strnum = display.Text += "9";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();
        }

        private void btn0_Click(object sender, EventArgs e) {
            string strnum = display.Text += "0";
            int intNum = int.Parse(strnum);
            display.Text = intNum.ToString();

        }

        private void button10_Click(object sender, EventArgs e) {
   
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            display.Text += "÷";
        }

        private void btnMult_Click(object sender, EventArgs e) {
            display.Text += "×";
        }

        private void btnSub_Click(object sender, EventArgs e) {
            display.Text += "－";
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            display.Text += "＋";
        }

        private void butCal_Click(object sender, EventArgs e) {

            secondOperand = int.Parse(display.Text);
            if (currentOperator == Operators.Add) {
                firstOperand= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract) {
                firstOperand = secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiplay) {
                firstOperand = secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide) {
                if(secondOperand == 0) {
                    display.Text = "0으로 나눌수 없습니다.";
                }
                else {
                    firstOperand = secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }
    }
}

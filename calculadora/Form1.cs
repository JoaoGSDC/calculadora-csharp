using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double resultValue;
        public String mathOperation = "";
        public double firstNumberOperation = 0;
        public double secondNumberOperation = 0;
        public double decimalValue = 0;
        public int countDecimalValue = 0;

        public double mathOperationAddition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double mathOperationSubtration(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double mathOperationMultiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double mathOperationDivision(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            mathOperation = btnAddition.Text;
            countDecimalValue = 0;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            mathOperation = btnSubtraction.Text;
            countDecimalValue = 0;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            mathOperation = btnMultiplication.Text;
            countDecimalValue = 0;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            mathOperation = btnDivision.Text;
            countDecimalValue = 0;
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            if (mathOperation.Equals(""))
            {
                if (firstNumberOperation == 0)
                {
                    firstNumberOperation = Convert.ToDouble(btnNumberOne.Text);
                    txtResult.Text = Convert.ToString(firstNumberOperation);
                } else
                {
                    firstNumberOperation += countDecimalValue == 0 ? Convert.ToDouble(btnNumberOne.Text) : decimalValue;
                    txtResult.Text = Convert.ToString(firstNumberOperation);
                }
            } else
            {
                secondNumberOperation += countDecimalValue == 0 ? Convert.ToDouble(btnNumberOne.Text) : decimalValue;
                txtResult.Text = Convert.ToString(secondNumberOperation);
            }
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberTwo.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberTwo.Text);
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberThree.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberThree.Text);
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberFour.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberFour.Text);
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberFive.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberFive.Text);
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberSix.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberSix.Text);
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberSeven.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberSeven.Text);
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberEight.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberEight.Text);
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberNine.Text);
            secondNumberOperation = Convert.ToDouble(btnNumberNine.Text);
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            firstNumberOperation = Convert.ToDouble(btnNumberZero.Text); 
            secondNumberOperation = Convert.ToDouble(btnNumberZero.Text);
        }

        private void btnDotte_Click(object sender, EventArgs e)
        {
            countDecimalValue++;
            decimalValue = firstNumberOperation / Math.Pow(10, countDecimalValue);
        }

        // Se o numero firstNumberOperation tiver valor, então tem que adicionar o valor dividido pelo exponencial
    }
}

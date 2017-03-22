using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;//Button выполняет работает с кнопкой на которую мы нажимаем
            Display.Text += btn.Text;
       }
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;//Button выполняет работает с кнопкой на которую мы нажимаем
            calc.firstnumber = double.Parse(Display.Text);
            calc.operation = btn.Text;  
            Display.Text = "";
        }
        private void result_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;//Button выполняет работает с кнопкой на которую мы нажимаем
           if(calc.operation !="Sqrt" && calc.operation != "1/X" && calc.operation != "x^2")
            {
                calc.secondnumber = double.Parse(Display.Text);
                calc.calculate();
                Display.Text = calc.result.ToString();
            }
            else
            {
                calc.calculate();
                Display.Text = calc.result.ToString();
            }
        }
        private void C_click(object sender,EventArgs e)
        {
            Display.Text = "";
            Calc calc = new Calc();
        }
        private void CE_click(object sender,EventArgs e)
        {
            Display.Text = "";
            Calc calc = new Calc();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Display.Text != "")
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);

        }
    
      
    }
}

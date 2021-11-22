using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstValue = double.NaN;
        double SecondValue = double.NaN;
        string Char;

        public MainWindow()
        {
            InitializeComponent();
        }

        public double Calc(string Symb)
        {
            switch (Symb)
            {
                case "+":
                    return FirstValue + SecondValue;
                case "-":
                    return FirstValue - SecondValue;
                case "*":
                    return FirstValue * SecondValue;
                case "/":
                    return FirstValue / SecondValue;
                default: 
                    return 0;
            }
        }

        public void CharLogic(string symb)
        {
                if (Char != "")
                {
                    FirstValue = Convert.ToDouble(LableMain.Content);
                    LableMain.Content = LableMain.Content.ToString().Split($" ")[0] + $" {symb} ";
                    Char = symb;

                }
                else
                {
                    FirstValue = Convert.ToDouble(LableMain.Content);
                    LableMain.Content = LableMain.Content + $" {symb} ";
                    Char = symb;
                }
            
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "1";
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "2";
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "3";
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "4";
        }

        private void BtnFive_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "5";
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "6";
        }

        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "7";
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "8";
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = LableMain.Content + "9";
        }

        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            if (LableMain.Content != "")
            {
                LableMain.Content = LableMain.Content + "0";
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            LableMain.Content = "";
            FirstValue = 0;
            SecondValue = 0;
            Char = "";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            CharLogic("/");
        }

        private void BtnIncrease_Click(object sender, RoutedEventArgs e)
        {
            CharLogic("*");
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            CharLogic("+");
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            CharLogic("-");
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (Char != "")
            {
                try
                {
                    SecondValue = Convert.ToDouble(LableMain.Content.ToString().Split($" {Char} ")[1]);
                    LableMain.Content = Calc(Char);
                    FirstValue = double.NaN;
                    SecondValue = double.NaN;
                    Char = "";
                }
                catch { };
            }
        }
    }
}
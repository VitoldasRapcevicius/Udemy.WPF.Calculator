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

namespace Udemy.WPF.Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            perecentageButton.Click += PerecentageButton_Click;
        }

        private void PerecentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(),out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content=lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString()=="0")
            {
                resultLabel.Content = 7;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void perecentageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sharingButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

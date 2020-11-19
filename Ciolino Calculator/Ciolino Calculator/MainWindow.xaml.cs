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

namespace Ciolino_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            Factorial();
            Permutations();
            Combinations();
        }
        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }
        public void Permutations()
        {
            double nValue = 0;
            double rValue = 0;
            double nMinusR = 0;
            nValue = Convert.ToDouble(xNObjects.Text);
            rValue = Convert.ToDouble(xRSample.Text);
            nMinusR = nValue - rValue;
            double tempFactorial1 = 1;
            double tempFactorial2 = 1;
            double permutaionAnswer = 0;
            for (int x = 1; x <= nValue; x++)
            {
                tempFactorial1 = tempFactorial1 * x;
            }
            for (int x = 1; x <= nMinusR; x++)
            {
                tempFactorial2 = tempFactorial2 * x;
            }
            permutaionAnswer = tempFactorial1 / tempFactorial2;
            xPermutationAnswer.Text = Convert.ToString(permutaionAnswer);
            


        }

        public void Combinations()
        {
            
            double nValue = 0;
            double rValue = 0;
            double nMinusR = 0;
            nValue = Convert.ToDouble(xNObjects.Text);
            rValue = Convert.ToDouble(xRSample.Text);
            double tempFactorial1 = 1;
            double tempFactorial2 = 1;
            double tempFactorial3 = 1;
            double combinationAnswer = 0;
            nMinusR = nValue - rValue;
            for (int x = 1; x <= nValue; x++)
            {
                tempFactorial1 = tempFactorial1 * x;
            }
            for (int x = 1; x <= rValue; x++)
            {
                tempFactorial2 = tempFactorial2 * x;
            }
            for (int x = 1; x <= nMinusR; x++)
            {
                tempFactorial3 = tempFactorial3 * x;
            }
            combinationAnswer = tempFactorial1 / (tempFactorial2 * tempFactorial3);
            xCombinationAnswer.Text = Convert.ToString(combinationAnswer);
        }


        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

using System.Windows;
using System.Windows.Controls;
namespace calcul
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            double num1;
            double num2;
            double execute;
            string result;
            string calculator = Operator.Text;
            switch (calculator)
            {
                case "+":
                    num1 = Convert.ToDouble(NumberA.Text);
                    num2 = Convert.ToDouble(NumberB.Text);
                    execute = num1 + num2;
                    result = Convert.ToString(execute);
                    ResultL.Content = result;
                    break;
                case "-":
                    num1 = Convert.ToDouble(NumberA.Text);
                    num2 = Convert.ToDouble(NumberB.Text);
                    execute = num1 - num2;
                    result = Convert.ToString(execute);
                    ResultL.Content = result;
                    break;
                case "*":
                    num1 = Convert.ToDouble(NumberA.Text);
                    num2 = Convert.ToDouble(NumberB.Text);
                    execute = num1 * num2;
                    result = Convert.ToString(execute);
                    ResultL.Content = result;
                    break;
                case "/":
                    num1 = Convert.ToDouble(NumberA.Text);
                    num2 = Convert.ToDouble(NumberB.Text);
                    if (num2 == 0)
                    {
                        ResultL.Content = "На 0 делить нельзя";
                    }
                    else
                    {
                        execute = num1 / num2;
                        result = Convert.ToString(execute);
                        ResultL.Content = result;
                    }
                    break;
                case "^":
                    num1 = Convert.ToDouble(NumberA.Text);
                    num2 = Convert.ToDouble(NumberB.Text);
                    execute = Math.Pow(num1, num2);
                    result = Convert.ToString(execute);
                    ResultL.Content = result;
                    break;
                case "!":
                    num1 = Convert.ToDouble(NumberA.Text);
                    execute = 1;
                    while (num1 >= 1)
                    {
                        execute = num1 * execute;
                        num1--;
                    }
                    result = Convert.ToString(execute);
                    ResultL.Content = result;
                    break;
                case "":
                    int a = Convert.ToInt32(NumberA.Text);
                    int b = Convert.ToInt32(NumberB.Text);
                    if (b == 2 || b == 8 || b == 10 || b == 16)
                    {
                        string sum = Convert.ToString(a, b);
                        result = Convert.ToString(sum);
                        ResultL.Content = result;
                    }
                    else
                    {
                        string sum = "";
                        while (a > 0)
                        {
                            int res = a % b;
                            a /= b;
                            sum = res.ToString() + sum;
                        }
                        ResultL.Content = sum;
                    }
                    break;
                default:
                    ResultL.Content = "Ошибка";
                    break;
            }
        }
        private void Operator_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NumberA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NumberB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
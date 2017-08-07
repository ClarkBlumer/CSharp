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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        int result = 10;
        public MainWindow()
        {
            InitializeComponent();
            num1 = textBox1.GetValue;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonPlus.IsChecked == true)
            {
                result = num1 + num2;
                label. = "+";
            }
            if (radioButtonMinus.IsChecked == true)
                result = num1 - num2;
            textBox3.Text = result.ToString();
        }
    }
}

/*
 * Date and Time picker. Calendar to pick a date/year.  A Submit button to log the date/time
 * and a message box that alerts the user of their selection. Format: "Your appointment is date, # days from now"
 * 
 * 
 * 
*/
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

namespace DateTimePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DateTime time = System.DateTime.Now;
            displayTime.Text = String.Format("{0:t}", time);
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                label.Content = String.Format("{0: M/d/yyyy}\n", date);
            }
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            int index = displayTime.SelectionStart;
            string st = displayTime.Text;
            DateTime time = DateTime.Parse(displayTime.Text);

            if ((st.Length - index) < 3)
            {
                time = time.AddHours(12);
            }
            else if ((st.Length - index) <= 5 && (st.Length - index) >= 3)
            {
                time = time.AddMinutes(1);
            }
            else
                time = time.AddHours(1);

            displayTime.Text = String.Format("{0:t}", time);
            displayTime.CaretIndex = index;
            
        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            int index = displayTime.SelectionStart;
            string st = displayTime.Text;
            DateTime time = DateTime.Parse(displayTime.Text);

            if ((st.Length - index) < 3)
            {
                time = time.AddHours(-12);
            }
            else if ((st.Length - index) <= 5 && (st.Length - index) >= 3)
            {
                time = time.AddMinutes(-1);
            }
            else
                time = time.AddHours(-1);

            displayTime.Text = String.Format("{0:t}", time);
            displayTime.CaretIndex = index;
        }
    }
}

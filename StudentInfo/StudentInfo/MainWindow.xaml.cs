using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }



        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = "";

            //Calls base constructor then uses the public setters to set values
            Student student = new Student();
            student.firstName = firstTextBox.Text;
            student.lastName = lastTextBox.Text;

            //Since I parse the information from text, I add the try/catch blocks 
            //which catch blank entries, or non-integer/double values. If those fields are
            //left blank or a value entered exceeds their range, default values of 0000 and 0.0 are
            //used. 
            try
            {
                student.studentID = int.Parse(idTextBox.Text);
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Student ID requires a 4 digit value");
            }
            try
            {
                student.GPA = double.Parse(gpaTextBox.Text);
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("GPA field requires a  0.0 - 4.0 decimal value");
            }

            
            studentList.Add(student);
            for(int i = 0; i < studentList.Count; i++)
            {
                infoLabel.Content += studentList[i].ToString();
            }

            //clear out the previous information
            idTextBox.Text = "";
            firstTextBox.Text = "";
            lastTextBox.Text = "";
            gpaTextBox.Text = "";

        }   



        private void gpaSortButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = "";
            List<Student> SortedList = studentList.OrderByDescending(o=>o.GPA).ToList();
            for (int i = 0; i < studentList.Count; i++)
            {
                infoLabel.Content += SortedList[i].ToString();
            }
        }



        private void idSortButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = "";
            List<Student> SortedList = studentList.OrderBy(o => o.studentID).ToList();
            for (int i = 0; i < studentList.Count; i++)
            {
                infoLabel.Content += SortedList[i].ToString();
            }
        }

        private void nameSortButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = "";
            List<Student> SortedList = studentList.OrderBy(o => o.firstName).ToList();
            for (int i = 0; i < studentList.Count; i++)
            {
                infoLabel.Content += SortedList[i].ToString();
            }
        }
    }
}

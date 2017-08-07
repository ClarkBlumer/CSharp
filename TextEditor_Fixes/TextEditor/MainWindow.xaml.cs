/*
 * Clark Blumer
 * cjbq4f
 * INFOTC 4400
 * Assignment 4 - TextEditor v2 
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
using System.Windows.Forms;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextDocument textDocument = new TextDocument();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            if (textDocument.isChanged && System.Windows.Forms.MessageBox.Show("Want to save your changes?", "Save changes?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (textDocument.filePath != null)
                    textDocument.Save(textDocument.filePath, textBox);
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;


                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        textDocument.Save(saveFileDialog.FileName, textBox);
                    }

                }
                textBox.Text = "";
                //textDocument.isChanged = false;
            }
            textBox.Text = "";
            textDocument.isChanged = false;
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            if (textDocument.isChanged && System.Windows.Forms.MessageBox.Show("Want to save your changes?", "Save changes?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (textDocument.filePath != null)
                    textDocument.Save(textDocument.filePath, textBox);
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;


                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        textDocument.Save(saveFileDialog.FileName, textBox);
                    }

                }
                //textBox.Text = "";
                //textDocument.isChanged = false;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = "";
                textDocument.Load(openFileDialog.FileName, textBox);
            }
            textDocument.filePath = openFileDialog.FileName;//takes note of where the user opened the file from
            textDocument.isChanged = false; //loading the file in will trigger the TextChanged event, so I set it to false here so users can exit after loading if nothing has changed

        }

        private void MenuItem_Save_Click(object sender, RoutedEventArgs e)
        {
            //if user opens a file, or already chose to Save As somewhere, 
            //this gets the filepath and just directly saves
            if(textDocument.filePath != null)
                textDocument.Save(textDocument.filePath, textBox);   
            else
            {
                //This else block covers the user not specifying a save location
                //prior to using the Save feature.  It will bring up the SaveDialog 
                //to ask the user where to save. Any preceeding clicks will directly save
                //where user specified.
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textDocument.Save(saveFileDialog.FileName, textBox);
                }
                textDocument.filePath = saveFileDialog.FileName;//take note of where the user saved to
                textDocument.isChanged = false;//after saving the document, I set the isChanged back to false for ease of saving/exiting
            }
            
        }

        private void MenuItem_SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textDocument.SaveAs(saveFileDialog.FileName, textBox);
            }
            textDocument.filePath = saveFileDialog.FileName;
            textDocument.isChanged = false;
        }


        public void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (textDocument.isChanged && System.Windows.Forms.MessageBox.Show("Want to save your changes?", "Save changes?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if(textDocument.filePath != null)
                    textDocument.Save(textDocument.filePath, textBox);
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;


                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        textDocument.Save(saveFileDialog.FileName, textBox);
                    }
                    
                }
                Close();
            }
            else
            {
                Close();
            }
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textDocument.isChanged = true;
            Save.IsEnabled = !string.IsNullOrWhiteSpace(textBox.Text);
            
        }

        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("I really liked this assignment. It was interesting to see all the user friendly elements that can go into something so 'mundane' nowadays like a text editor.\n -Clark Blumer", "About assignment!", MessageBoxButtons.OK);
        }
    }
}

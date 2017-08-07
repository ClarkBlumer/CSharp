using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TextEditor
{
    class TextDocument
    {
        public string filePath = null;
        public bool isChanged = false;

        //Pass the fileName/path and the textBox
        public void Load(String fileName, TextBox textBox)
        {
            try
            {
                //I put this in a try block so if a non-text file is tried
                //to open, it should throw the exception. The openfiledialogue is set to only txt files
                //so the user shouldn't be able to select non-txt files, but just as a precaution.
                textBox.Text = File.ReadAllText(fileName);
                    
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }


        public void SaveAs(String fileName, TextBox textBox)
        {
            //Since we are just using text documents, I chose to go
            //go with an option that is available in c# rather
            //than using a streamIO, File.WriteAllText takes a file
            //and a source and just saves it as is. 
            File.WriteAllText(fileName, textBox.Text);
        }

        public void Save(String fileName, TextBox textBox)
        {
            if(fileName != null)
                File.WriteAllText(fileName, textBox.Text);
        }
    }
}

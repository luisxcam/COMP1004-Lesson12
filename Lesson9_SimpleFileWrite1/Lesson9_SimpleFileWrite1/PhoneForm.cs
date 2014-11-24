/* Program:		    Ch9SimpleFileWrite
    Programmer:	    Anju Chawla
    Date:			November 2014
    Description:	Allow the user to enter names and phone numbers and
				    save them in a file.
				    Uses the simplified C# file access methods.              */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson9_SimpleFileWrite1
{
    public partial class PhoneForm : Form
    {

        // Class-level variables
        string[] phoneData = new string[10];
        int indexInteger;

        public PhoneForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Save the record to the end of the File.

            string FileName = "TextFile.txt";
            //string StringToWrite = NameTextBox.Text + "\n" + PhoneTextBox.Text + "\n";
            string StringToWrite = NameTextBox.Text + Environment.NewLine + PhoneTextBox.Text + Environment.NewLine;

            // This line opens the file, appends to the end of the file and closes it.
            File.AppendAllText(FileName, StringToWrite);

            // Call the ResetForm method
            ResetForm();

        }

        private void ResetForm()
        {
            // This is a custom method that resets the form fields

            // Reset the form
            PhoneTextBox.Clear();
            NameTextBox.Clear();
            NameTextBox.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }




    }
}

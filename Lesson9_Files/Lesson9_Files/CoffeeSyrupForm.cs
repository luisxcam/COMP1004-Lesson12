/*
 * Name : Anju Chawla
 * Date : Nov.11, 2014
 * Purpose: To allow the user to select coffee and syrup flavours.
 * New coffee flavours can be added and remove/remove all coffee flavours
 * Prints all coffee flavours and selected ones too.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_Files
{
    public partial class CoffeeSyrupForm : Form
    {
        //variable definition
        private StreamReader coffeeStreamReader;
        private StreamWriter coffeeStreamWriter;
        private Boolean isDirtyBoolean = false;

        public CoffeeSyrupForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the information

            AboutBox1 information = new AboutBox1();
            information.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean itemFoundBoolean = false;
            int itemIndexInteger = 0;
            //add a new coffee flavour if it does not exist

            //if the user has provided a new flavour
            if (coffeeComboBox.Text.Trim() != String.Empty)
            {
                //check if the flavour already exists

                while (!itemFoundBoolean && itemIndexInteger < coffeeComboBox.Items.Count)
                {
                    if (coffeeComboBox.Text.ToUpper() == coffeeComboBox.Items[itemIndexInteger].ToString().ToUpper())
                    {
                        itemFoundBoolean = true;
                    }
                    else
                    {
                        itemIndexInteger++;
                    }

                }
                //if flavour found
                if (itemFoundBoolean)
                {
                    MessageBox.Show("Duplicate Flavour cannot be added", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    coffeeComboBox.Focus();
                }
                else
                {
                    //add the flavour
                    coffeeComboBox.Items.Add(coffeeComboBox.Text);
                    coffeeComboBox.Text = "";
                    isDirtyBoolean = true;
                }


            }
            else
            {
                MessageBox.Show("Enter a coffee flavour to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }

        }

        private void removeCoffeeFlavourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //remove a flavour if it exists

            //no selection made
            if (coffeeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the coffee flavour to delete",
                    "No Selection Made", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();

            }
            //remove coffee 
            else
            {
                //coffeeComboBox.Items.RemoveAt(coffeeComboBox.SelectedIndex);
                coffeeComboBox.Items.Remove(coffeeComboBox.Items[coffeeComboBox.SelectedIndex]);
                isDirtyBoolean = true;

            }

        }

        private void clearCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear all coffee flavours

            DialogResult confirm = MessageBox.Show("Clear all coffee flavours",
                "Clear Coffee list", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (confirm == System.Windows.Forms.DialogResult.Yes)
            {
                coffeeComboBox.Items.Clear();
                isDirtyBoolean = true;
            }


        }

        private void countCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the number of flavours
            string messageString = "The number of available coffee flavours is "
                                   + coffeeComboBox.Items.Count;

            MessageBox.Show(messageString, "Coffee Flavours",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }

        private void printAllDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Handle printing and print previews when printing all.

            Font printFont = new Font("Arial", 12);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Print the heading
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Flavours", headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Loop through the entire list.
            //for (int ListIndexInteger = 0; ListIndexInteger < CoffeeComboBox.Items.Count - 1; ListIndexInteger++)
            foreach (Object flavor in coffeeComboBox.Items)
            {
                //increment the  Y position for the next line.
                verticalPrintLocationFloat += lineHeightFloat;

                //Set up a line
                //PrintLineString = CoffeeComboBox.Items[ListIndexInteger].ToString();
                printLineString = flavor.ToString();
                //Send the line to the graphics page object.
                e.Graphics.DrawString(printLineString, printFont,
                    Brushes.Black, horizontalPrintLocationFloat,
                    verticalPrintLocationFloat);
            } // end for
        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print all flavours
            printAllDocument.Print();

        }

        private void previewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //preview the coffee flavours
            printPreviewDialog1.Document = printAllDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printSelectedDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing selected items.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Set up and display heading lines
            printLineString = "Print Selected Item";
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
            printLineString = "by Anju Chawla";
            verticalPrintLocationFloat += lineHeightFloat;
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Leave a blank line between the heading and detail line.
            verticalPrintLocationFloat += lineHeightFloat * 2;
            // Set up the selected line.
            printLineString = "Coffee: " + coffeeComboBox.Text +
                "     Syrup: " + syrupListBox.Text;
            // Send the line to the graphics page object.
            e.Graphics.DrawString(printLineString, printFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
        }

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print selected flavours

            if (syrupListBox.SelectedIndex == -1)
            {
                syrupListBox.SelectedIndex = 0;
            }

            if (coffeeComboBox.SelectedIndex != -1)
            {
                printSelectedDocument.Print();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }

        }

        private void previewSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syrupListBox.SelectedIndex == -1)
            {
                syrupListBox.SelectedIndex = 0;
            }

            if (coffeeComboBox.SelectedIndex != -1)
            {
                printPreviewDialog1.Document = printSelectedDocument;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show a save dialog box and save the coffee flavours
            DialogResult responseDialogResult;

            //Check if it is open, close if opened
            if (coffeeStreamWriter != null)
                coffeeStreamWriter.Close();

            //of the file open dialog box
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.FileName = "CoffeeFlavour";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.Filter = "TextFiles(*.txt)|*.txt|All Files(*.*)|*.*";

            //show the save dialog and get the user's answer
            responseDialogResult = saveFileDialog1.ShowDialog();

            //check the answer to proceed
            if (responseDialogResult == System.Windows.Forms.DialogResult.OK) {
                try {
                    coffeeStreamWriter = new StreamWriter(saveFileDialog1.FileName);

                    //copy the coffee flavours to the file
                    foreach (Object coffee in coffeeComboBox.Items)
                    {
                        Console.WriteLine(coffee.ToString());
                        coffeeStreamWriter.WriteLine(coffee.ToString());
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error in creating file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //not defined...
            }


        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the open file dialog and allow the user to choose
            DialogResult responseDialogResult;
            String coffeeNameString;

            //set the properties of the file is already open
            if (coffeeStreamReader != null)
                coffeeStreamReader.Close();

            //of the file open dialog box
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.FileName = "CoffeeFlavour.txt";
            openFileDialog1.Title = "Select file or directory";
            openFileDialog1.Filter = "TextFiles(*.txt)|*.txt|All Files(*.*)|*.*";

            //show it
            responseDialogResult = openFileDialog1.ShowDialog();

            //make sure that cancel was not selected
            if (responseDialogResult != System.Windows.Forms.DialogResult.Cancel)
            {
                //open the file
                try {
                    coffeeStreamReader = new StreamReader(openFileDialog1.FileName);

                    //populate the coffee flavours
                    coffeeComboBox.Items.Clear();

                    //populate the coffee flavours
                    ///while the file is not done reading
                    while (coffeeStreamReader.Peek() != -1)
                    {
                        coffeeNameString = coffeeStreamReader.ReadLine();
                        coffeeComboBox.Items.Add(coffeeNameString);
                    }

                    coffeeStreamReader.Close();
                }
                catch (FileNotFoundException ex) {
                    MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //close the application
                //this.Close();
            }
        }

        private void CoffeeSyrupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ensure changes were made
            DialogResult responseDialogResult;
            if (isDirtyBoolean)
            {
                responseDialogResult = MessageBox.Show("Coffee list has changed. Do you want to save changes?", "Save coffee List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (responseDialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFileToolStripMenuItem_Click(sender, e);
                }
            }
            

            //close files open
            if (coffeeStreamReader != null)
                coffeeStreamReader.Close();
            if (coffeeStreamWriter != null)
                coffeeStreamWriter.Close();
        }

        private void CoffeeSyrupForm_Load(object sender, EventArgs e)
        {
            //show the open file menu when the form loads
            openFileToolStripMenuItem_Click(sender, e);
        }
    }
}

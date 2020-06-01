//**********************************************************
//Programmer: Daniel Gutierrez
//Date: 24/05/2020
//Software: Microsoft Visual Studio 2019 Community Edition
//Platform: Microsoft winodws 10 Pro
//Purpose: Assessment 2
//**********************************************************




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Required for file operations


namespace Assessment2
{
    public partial class FormQ5 : Form
    {
        private StreamReader fileReader;      //Reads data to a text file

        public FormQ5()
        {

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Declaring variables
        string fileName;
        int[] myArraySort = new int[4];

        public void readFile()
        {

            //Set filter for open file dialog
            dlgOpen.Filter = "Text files (*.txt)|*.txt";

            //Capture file name from open file dialog
            if (dlgOpen.ShowDialog() != DialogResult.Cancel)
            {
                fileName = dlgOpen.FileName;
            }

            //Open file with read access
            FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);   //Set file from where data is read
            fileReader = new StreamReader(input);

            //Storing data in Array
            for (int i = 0; i < 4; i++)
            {
                //Get values from text boxes
                String inputRecord = fileReader.ReadLine();

                if (inputRecord != null)
                { //Not end‐of‐file                  

                    myArraySort[i] = Convert.ToInt32(inputRecord);

                }
                else
                    MessageBox.Show("Line is empty.");  //shows message
            }

            //Refreshing list
            refreshList();

            //Displaying information for user: enable/disable buttons and showing messages
            lblAddress.Text = fileName;//Displays file's address
        }


        public void refreshList()
        {
            lstBox.Items.Clear(); //Clearing list box

            //Adding data to listbox
            for (int i = 0; i < 4; i++)
                lstBox.Items.Add(myArraySort[i]);
        }


        private void btnFile_Click(object sender, EventArgs e)
        {
            readFile();

            refreshList();

            //Displaying information for user: enable/disable buttons and showing messages
            btnFile.Enabled = false;
            btnSort.Enabled = true;

        }
    }
}

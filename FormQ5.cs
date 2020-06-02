//**********************************************************
//Programmer: Daniel Gutierrez
//Date: 24/05/2020
//Software: Microsoft Visual Studio 2019 Community Edition
//Platform: Microsoft winodws 10 Pro
//Purpose: Assessment 2
//**********************************************************




using System;
using System.Collections;
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
        //Reads data to a text file
        private StreamReader fileReader;
        //Array of Class Person
        ArrayList myCollection = new ArrayList();
        //Variable for reading file
        string fileName,sortType;

        public FormQ5()
        {

            InitializeComponent();
        }

        //Creating class
        public class Person:IComparable
        {
            public string name;
            public int age;
            public double hight;

            public int CompareTo(object obj)
            {
                Person other = (Person)obj;
                    return this.age - other.age;    
            }
        }

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
                    string[] inputFields; //Will store individual pieces of data 
                    inputFields = inputRecord.Split(','); //Specifies comma as the delimiter between fields
                    string newName = inputFields[0];
                    int newAge = Convert.ToInt32(inputFields[1]);
                    double newHight = Convert.ToDouble(inputFields[2]);

                    //CREATING OBJECT AND ADDING DATA PERO OBJECT
                    myCollection.Add(new Person()
                    {
                        name = newName,
                        age = newAge,
                        hight = newHight
                    });
                }
                else
                    MessageBox.Show("Line is empty.");  //shows message
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            readFile();
            refreshList();
            //Displaying information for user: enable/disable buttons and showing messages
            lblAddress.Text = fileName;//Displays file's address
            btnFile.Enabled = false;
            btnSort.Enabled = true;
        }

        public void refreshList()
        {
            lstBox.Items.Clear(); //Clearing list box
            foreach (Person rec in myCollection)
                lstBox.Items.Add(rec.name + " age: " + rec.age + " hight: " + rec.hight);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            myCollection.Sort();
            refreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



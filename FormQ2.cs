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

namespace Assessment2
{
    public partial class FormQ2 : Form
    {
        public FormQ2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQ2_Load(object sender, EventArgs e)
        {
            //Enable drag&drop for this form
            this.AllowDrop = true;
            
            //Add event handlers for drag&drop functionality
            this.DragEnter += new DragEventHandler(FormQ2_DragEnter);
            this.DragDrop += new DragEventHandler(FormQ2_DragDrop);

        }

        private void FormQ2_DragEnter(object sender, DragEventArgs e)
        {
            //Stablishing effect when droping image (copy image location)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void FormQ2_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (String File in FileList) {

                //Getting/showing the file location
                this.txtDrag.Text = File;

                //Declaring image variable             
                Bitmap MyImage; 

                // Stretches the image to fit the pictureBox.
                this.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                MyImage = new Bitmap(File);

                //Assigning the image to the picBox
                this.picBox.Image = (Image)MyImage; 
            }
                
        }
    }
}

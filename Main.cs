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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush grayBrush = new SolidBrush(Color.Gray);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush orangeBrush = new SolidBrush(Color.Orange);
            Brush blueBrush = new SolidBrush(Color.Blue);


            //g.DrawLine(myPen, 2, 2, 300, 150);
            //g.DrawArc(myPen, 400, 100, 50, 50, 0, 90);
            //g.DrawRectangle(myPen, 200, 100, 250, 150);

            //Wall
            g.FillRectangle(orangeBrush, 0, 0, 650, 400);

            //Television
            g.FillRectangle(blackBrush, 200, 100, 250, 150);
            g.FillRectangle(grayBrush, 215, 115, 220, 120);

            //Speaker 1
            g.FillRectangle(blackBrush, 100, 100, 50, 80);
            g.FillEllipse(grayBrush, 110, 110, 30, 30);
            g.FillEllipse(brownBrush, 117, 155, 15, 15);

            //Speaker 2
            g.FillRectangle(blackBrush, 100 + 400, 100, 50, 80);
            g.FillEllipse(grayBrush, 110 + 400, 110, 30, 30);
            g.FillEllipse(brownBrush, 117 + 400, 155, 15, 15);

            //Table
            g.FillRectangle(brownBrush, 180, 255, 290, 20);
            g.FillRectangle(brownBrush, 180, 275, 20, 90);
            g.FillRectangle(brownBrush, 450, 275, 20, 90);

            //Text
            Font drawFont = new Font("Arial", 16);
            PointF drawPoint = new PointF(25.0F, 35.0F);
            g.DrawString("Question #1:", drawFont, blueBrush, drawPoint);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Author: Daniel Gutierrez CIT210097. Copyright 2020", "Assessment 2");  //shows message
        }

        private void question2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmCustomer is the (name) in its properties
            FormQ2 myFormQ2 = new FormQ2();
            myFormQ2.ShowDialog();

        }

        private void question3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shows Help windows
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\help.chm", HelpNavigator.Topic);
        }

        private void question4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCustomer is the (name) in its properties
            FormQ4 myFormQ4 = new FormQ4();
            myFormQ4.ShowDialog();
        }

        private void question5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCustomer is the (name) in its properties
            FormQ5 myFormQ5 = new FormQ5();
            myFormQ5.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Shows Help windows
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory+"\\help.chm", HelpNavigator.Topic);
        }
    }
}

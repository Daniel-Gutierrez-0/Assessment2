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
    public partial class FormQ4 : Form
    {
        public FormQ4()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class Library
        {
            private List<Book> myCollection = new List<Book>();

            public void AddBook(string title, int qty, decimal price)
            {
                Book myBook = new Book();
                myBook.Title = title;
                myBook.Quantity = qty;
                myBook.Price = price;
                myCollection.Add(myBook);
            }

            public int TotalBooks()
            {
                int totalBooks = 0;
                foreach (Book record in myCollection)
                {
                    totalBooks += record.Quantity;
                }
                return totalBooks;
            }

            public decimal TotalBooksPrice()
            {
                decimal totalPrice = 0;
                foreach (Book record in myCollection)
                {
                    totalPrice += (record.Price* record.Quantity);
                }
                return totalPrice;
            }


            // Nested class
            private class Book
            {
                public string Title { get; set; }
                public int Quantity { get; set; }
                public decimal Price { get; set; }

            }
        }


        Library newBook = new Library();
        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int quantity = Convert.ToInt32(txtQty.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);

            //Adding new book to collection
            newBook.AddBook(title, quantity, price);

            //Adding book to boxList
            lstBox.Items.Add(title + ", "+ quantity + ", " + price);

            //Clearing txt boxes
            txtTitle.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "The Total inventory price is: " + Convert.ToString(newBook.TotalBooksPrice());
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            txtResult.Text = "In the library there are " + Convert.ToString(newBook.TotalBooks() + " books");
        }
    }
}

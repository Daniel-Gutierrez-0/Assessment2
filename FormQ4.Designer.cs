namespace Assessment2
{
    partial class FormQ4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnQty = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(140, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(95, 89);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(95, 116);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(62, 20);
            this.txtQty.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(95, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(62, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please insert several books:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "The Book Store";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(34, 218);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(181, 82);
            this.lstBox.TabIndex = 10;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(34, 345);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(181, 20);
            this.txtResult.TabIndex = 11;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(34, 316);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(100, 23);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Total Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQty
            // 
            this.btnQty.ForeColor = System.Drawing.Color.Black;
            this.btnQty.Location = new System.Drawing.Point(140, 316);
            this.btnQty.Name = "btnQty";
            this.btnQty.Size = new System.Drawing.Size(75, 23);
            this.btnQty.TabIndex = 13;
            this.btnQty.Text = "Total Qty";
            this.btnQty.UseVisualStyleBackColor = true;
            this.btnQty.Click += new System.EventHandler(this.btnQty_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inventory:";
            // 
            // FormQ4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnQty);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQ4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question #4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnQty;
        private System.Windows.Forms.Label label6;
    }
}
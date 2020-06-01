namespace Assessment2
{
    partial class FormQ2
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
            this.btnClose = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtDrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox.ErrorImage = null;
            this.picBox.Location = new System.Drawing.Point(12, 29);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(376, 276);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // txtDrag
            // 
            this.txtDrag.Enabled = false;
            this.txtDrag.Location = new System.Drawing.Point(12, 328);
            this.txtDrag.Name = "txtDrag";
            this.txtDrag.Size = new System.Drawing.Size(376, 20);
            this.txtDrag.TabIndex = 2;
            this.txtDrag.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please drag and drop an image here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location of the image:";
            // 
            // FormQ2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrag);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQ2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question #2";
            this.Load += new System.EventHandler(this.FormQ2_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormQ2_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormQ2_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label2;
    }
}
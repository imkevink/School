namespace UI
{
    partial class BooksForm
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
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.lblReservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Location = new System.Drawing.Point(12, 9);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(65, 13);
            this.lblSelectBook.TabIndex = 0;
            this.lblSelectBook.Text = "Select Book";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(117, 6);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(293, 21);
            this.cmbBooks.TabIndex = 1;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.CmbBooks_SelectedIndexChanged);
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(12, 66);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(398, 56);
            this.lstReservations.TabIndex = 2;
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Location = new System.Drawing.Point(15, 47);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(69, 13);
            this.lblReservations.TabIndex = 3;
            this.lblReservations.Text = "Reservations";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 134);
            this.Controls.Add(this.lblReservations);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.lblSelectBook);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Label lblReservations;
    }
}
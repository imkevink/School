namespace UI
{
    partial class ReservationsForm
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
            this.lblReservations = new System.Windows.Forms.Label();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Location = new System.Drawing.Point(13, 13);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(69, 13);
            this.lblReservations.TabIndex = 0;
            this.lblReservations.Text = "Reservations";
            // 
            // lvReservations
            // 
            this.lvReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chCustomer,
            this.chBook});
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(12, 29);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(512, 132);
            this.lvReservations.TabIndex = 1;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chCustomer
            // 
            this.chCustomer.Text = "Customer";
            this.chCustomer.Width = 200;
            // 
            // chBook
            // 
            this.chBook.Text = "Book";
            this.chBook.Width = 248;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 173);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.lblReservations);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservations;
        private System.Windows.Forms.ListView lvReservations;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chCustomer;
        private System.Windows.Forms.ColumnHeader chBook;
    }
}
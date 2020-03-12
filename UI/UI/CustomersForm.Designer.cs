using System.Collections.Generic;
using Model;
using Logic;

namespace UI
{
    partial class CustomersForm
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
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.lblReservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(84, 13);
            this.lblSelectCustomer.TabIndex = 0;
            this.lblSelectCustomer.Text = "Select Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(135, 6);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.CmbCustomers_SelectedIndexChanged);
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(15, 64);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(241, 69);
            this.lstReservations.TabIndex = 2;
            // 
            // lblReservations
            // 
            this.lblReservations.AutoSize = true;
            this.lblReservations.Location = new System.Drawing.Point(15, 46);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(69, 13);
            this.lblReservations.TabIndex = 3;
            this.lblReservations.Text = "Reservations";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 150);
            this.Controls.Add(this.lblReservations);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lblSelectCustomer);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Label lblReservations;
    }
}
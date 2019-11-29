namespace Opgave5
{
    partial class Opgave5
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
            this.lblKlasse = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.lblRailrunner = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtRailrunner = new System.Windows.Forms.TextBox();
            this.rbtnTweedeKlasse = new System.Windows.Forms.RadioButton();
            this.rbtnEersteKlasse = new System.Windows.Forms.RadioButton();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKlasse
            // 
            this.lblKlasse.AutoSize = true;
            this.lblKlasse.Location = new System.Drawing.Point(13, 13);
            this.lblKlasse.Name = "lblKlasse";
            this.lblKlasse.Size = new System.Drawing.Size(41, 13);
            this.lblKlasse.TabIndex = 0;
            this.lblKlasse.Text = "Klasse:";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(13, 43);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(40, 13);
            this.lblAantal.TabIndex = 1;
            this.lblAantal.Text = "Aantal:";
            // 
            // lblRailrunner
            // 
            this.lblRailrunner.AutoSize = true;
            this.lblRailrunner.Location = new System.Drawing.Point(12, 73);
            this.lblRailrunner.Name = "lblRailrunner";
            this.lblRailrunner.Size = new System.Drawing.Size(58, 13);
            this.lblRailrunner.TabIndex = 2;
            this.lblRailrunner.Text = "Railrunner:";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(110, 40);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(100, 20);
            this.txtAantal.TabIndex = 3;
            // 
            // txtRailrunner
            // 
            this.txtRailrunner.Location = new System.Drawing.Point(110, 70);
            this.txtRailrunner.Name = "txtRailrunner";
            this.txtRailrunner.Size = new System.Drawing.Size(100, 20);
            this.txtRailrunner.TabIndex = 4;
            // 
            // rbtnTweedeKlasse
            // 
            this.rbtnTweedeKlasse.AutoSize = true;
            this.rbtnTweedeKlasse.Checked = true;
            this.rbtnTweedeKlasse.Location = new System.Drawing.Point(110, 12);
            this.rbtnTweedeKlasse.Name = "rbtnTweedeKlasse";
            this.rbtnTweedeKlasse.Size = new System.Drawing.Size(70, 17);
            this.rbtnTweedeKlasse.TabIndex = 5;
            this.rbtnTweedeKlasse.TabStop = true;
            this.rbtnTweedeKlasse.Text = "2e klasse";
            this.rbtnTweedeKlasse.UseVisualStyleBackColor = true;
            // 
            // rbtnEersteKlasse
            // 
            this.rbtnEersteKlasse.AutoSize = true;
            this.rbtnEersteKlasse.Location = new System.Drawing.Point(217, 12);
            this.rbtnEersteKlasse.Name = "rbtnEersteKlasse";
            this.rbtnEersteKlasse.Size = new System.Drawing.Size(70, 17);
            this.rbtnEersteKlasse.TabIndex = 6;
            this.rbtnEersteKlasse.Text = "1e klasse";
            this.rbtnEersteKlasse.UseVisualStyleBackColor = true;
            // 
            // btnBereken
            // 
            this.btnBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBereken.Location = new System.Drawing.Point(110, 116);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(110, 146);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.ReadOnly = true;
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 8;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(13, 149);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(29, 13);
            this.lblPrijs.TabIndex = 9;
            this.lblPrijs.Text = "Prijs:";
            // 
            // Opgave5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 183);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.rbtnEersteKlasse);
            this.Controls.Add(this.rbtnTweedeKlasse);
            this.Controls.Add(this.txtRailrunner);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblRailrunner);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblKlasse);
            this.Name = "Opgave5";
            this.Text = "NS Dagkaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlasse;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Label lblRailrunner;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtRailrunner;
        private System.Windows.Forms.RadioButton rbtnTweedeKlasse;
        private System.Windows.Forms.RadioButton rbtnEersteKlasse;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Label lblPrijs;
    }
}


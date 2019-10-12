namespace Opdracht_7
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textGraden = new System.Windows.Forms.TextBox();
            this.celToKel = new System.Windows.Forms.RadioButton();
            this.celToFahr = new System.Windows.Forms.RadioButton();
            this.fahrToCel = new System.Windows.Forms.RadioButton();
            this.btnOmrekenen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fahrToCel);
            this.groupBox1.Controls.Add(this.celToFahr);
            this.groupBox1.Controls.Add(this.celToKel);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Omrekenen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Graden";
            // 
            // textGraden
            // 
            this.textGraden.Location = new System.Drawing.Point(106, 10);
            this.textGraden.Name = "textGraden";
            this.textGraden.Size = new System.Drawing.Size(196, 20);
            this.textGraden.TabIndex = 2;
            // 
            // celToKel
            // 
            this.celToKel.AutoSize = true;
            this.celToKel.Location = new System.Drawing.Point(6, 33);
            this.celToKel.Name = "celToKel";
            this.celToKel.Size = new System.Drawing.Size(115, 17);
            this.celToKel.TabIndex = 0;
            this.celToKel.TabStop = true;
            this.celToKel.Text = "Celcius naar Kelvin";
            this.celToKel.UseVisualStyleBackColor = true;
            // 
            // celToFahr
            // 
            this.celToFahr.AutoSize = true;
            this.celToFahr.Location = new System.Drawing.Point(6, 56);
            this.celToFahr.Name = "celToFahr";
            this.celToFahr.Size = new System.Drawing.Size(139, 17);
            this.celToFahr.TabIndex = 1;
            this.celToFahr.TabStop = true;
            this.celToFahr.Text = "Celcius naar Fahrenheid";
            this.celToFahr.UseVisualStyleBackColor = true;
            // 
            // fahrToCel
            // 
            this.fahrToCel.AutoSize = true;
            this.fahrToCel.Location = new System.Drawing.Point(7, 80);
            this.fahrToCel.Name = "fahrToCel";
            this.fahrToCel.Size = new System.Drawing.Size(139, 17);
            this.fahrToCel.TabIndex = 2;
            this.fahrToCel.TabStop = true;
            this.fahrToCel.Text = "Fahrenheid naar Celcius";
            this.fahrToCel.UseVisualStyleBackColor = true;
            // 
            // btnOmrekenen
            // 
            this.btnOmrekenen.Location = new System.Drawing.Point(12, 172);
            this.btnOmrekenen.Name = "btnOmrekenen";
            this.btnOmrekenen.Size = new System.Drawing.Size(290, 23);
            this.btnOmrekenen.TabIndex = 3;
            this.btnOmrekenen.Text = "Omrekenen";
            this.btnOmrekenen.UseVisualStyleBackColor = true;
            this.btnOmrekenen.Click += new System.EventHandler(this.BtnOmrekenen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uitkomst";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.Location = new System.Drawing.Point(106, 211);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(196, 23);
            this.lblUitkomst.TabIndex = 5;
            this.lblUitkomst.Text = "0";
            this.lblUitkomst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 242);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOmrekenen);
            this.Controls.Add(this.textGraden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fahrToCel;
        private System.Windows.Forms.RadioButton celToFahr;
        private System.Windows.Forms.RadioButton celToKel;
        private System.Windows.Forms.TextBox textGraden;
        private System.Windows.Forms.Button btnOmrekenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUitkomst;
    }
}


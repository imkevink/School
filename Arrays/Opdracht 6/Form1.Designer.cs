﻿namespace Opdracht_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVooraf = new System.Windows.Forms.Label();
            this.labelAchteraf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVergelijkingsgetal = new System.Windows.Forms.TextBox();
            this.buttonVergelijk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inhoud tabel (vooraf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhoud tabel (achteraf)";
            // 
            // labelVooraf
            // 
            this.labelVooraf.AutoSize = true;
            this.labelVooraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVooraf.Location = new System.Drawing.Point(18, 42);
            this.labelVooraf.Name = "labelVooraf";
            this.labelVooraf.Size = new System.Drawing.Size(0, 13);
            this.labelVooraf.TabIndex = 2;
            // 
            // labelAchteraf
            // 
            this.labelAchteraf.AutoSize = true;
            this.labelAchteraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchteraf.Location = new System.Drawing.Point(153, 42);
            this.labelAchteraf.Name = "labelAchteraf";
            this.labelAchteraf.Size = new System.Drawing.Size(0, 13);
            this.labelAchteraf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vergelijkingsgetal";
            // 
            // textBoxVergelijkingsgetal
            // 
            this.textBoxVergelijkingsgetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVergelijkingsgetal.Location = new System.Drawing.Point(108, 422);
            this.textBoxVergelijkingsgetal.Name = "textBoxVergelijkingsgetal";
            this.textBoxVergelijkingsgetal.Size = new System.Drawing.Size(80, 20);
            this.textBoxVergelijkingsgetal.TabIndex = 5;
            // 
            // buttonVergelijk
            // 
            this.buttonVergelijk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVergelijk.Location = new System.Drawing.Point(194, 420);
            this.buttonVergelijk.Name = "buttonVergelijk";
            this.buttonVergelijk.Size = new System.Drawing.Size(93, 23);
            this.buttonVergelijk.TabIndex = 6;
            this.buttonVergelijk.Text = "Vergelijk";
            this.buttonVergelijk.UseVisualStyleBackColor = true;
            this.buttonVergelijk.Click += new System.EventHandler(this.ButtonVergelijk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.buttonVergelijk);
            this.Controls.Add(this.textBoxVergelijkingsgetal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAchteraf);
            this.Controls.Add(this.labelVooraf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Opdracht 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVooraf;
        private System.Windows.Forms.Label labelAchteraf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVergelijkingsgetal;
        private System.Windows.Forms.Button buttonVergelijk;
    }
}


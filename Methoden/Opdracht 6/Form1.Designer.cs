namespace Opdracht_6
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
            this.textGetal = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // textGetal
            // 
            this.textGetal.Location = new System.Drawing.Point(97, 10);
            this.textGetal.Name = "textGetal";
            this.textGetal.Size = new System.Drawing.Size(153, 20);
            this.textGetal.TabIndex = 1;
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(13, 50);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(237, 23);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Bereken met ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.BtnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(13, 79);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(237, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Bereken met out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(13, 109);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(237, 23);
            this.btnValue.TabIndex = 4;
            this.btnValue.Text = "Bereken met value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.BtnValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uitkomst";
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.Location = new System.Drawing.Point(84, 151);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(166, 23);
            this.lblUitkomst.TabIndex = 6;
            this.lblUitkomst.Text = "0";
            this.lblUitkomst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 178);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.textGetal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGetal;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUitkomst;
    }
}


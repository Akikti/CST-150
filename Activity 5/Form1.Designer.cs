
namespace Activity_5
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlastword = new System.Windows.Forms.MaskedTextBox();
            this.txtfirstword = new System.Windows.Forms.TextBox();
            this.txtlongest = new System.Windows.Forms.MaskedTextBox();
            this.txtvowel = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lower Case";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(127, 17);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(229, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(127, 63);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(320, 160);
            this.txtdisplay.TabIndex = 3;
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Word";
            this.label3.Click += new System.EventHandler(this.F_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Word";
            this.label4.Click += new System.EventHandler(this.lastword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Longest Word";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Most Vowels";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtlastword
            // 
            this.txtlastword.Location = new System.Drawing.Point(127, 283);
            this.txtlastword.Name = "txtlastword";
            this.txtlastword.Size = new System.Drawing.Size(320, 20);
            this.txtlastword.TabIndex = 8;
            this.txtlastword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtlastword_MaskInputRejected);
            // 
            // txtfirstword
            // 
            this.txtfirstword.Location = new System.Drawing.Point(127, 254);
            this.txtfirstword.Name = "txtfirstword";
            this.txtfirstword.Size = new System.Drawing.Size(320, 20);
            this.txtfirstword.TabIndex = 9;
            this.txtfirstword.TextChanged += new System.EventHandler(this.txtfirstword_TextChanged);
            // 
            // txtlongest
            // 
            this.txtlongest.Location = new System.Drawing.Point(127, 322);
            this.txtlongest.Name = "txtlongest";
            this.txtlongest.Size = new System.Drawing.Size(320, 20);
            this.txtlongest.TabIndex = 10;
            this.txtlongest.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtlongest_MaskInputRejected);
            // 
            // txtvowel
            // 
            this.txtvowel.Location = new System.Drawing.Point(127, 357);
            this.txtvowel.Name = "txtvowel";
            this.txtvowel.Size = new System.Drawing.Size(320, 20);
            this.txtvowel.TabIndex = 11;
            this.txtvowel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtvowel_MaskInputRejected);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 389);
            this.Controls.Add(this.txtvowel);
            this.Controls.Add(this.txtlongest);
            this.Controls.Add(this.txtfirstword);
            this.Controls.Add(this.txtlastword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtlastword;
        private System.Windows.Forms.TextBox txtfirstword;
        private System.Windows.Forms.MaskedTextBox txtlongest;
        private System.Windows.Forms.MaskedTextBox txtvowel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


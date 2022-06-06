using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        String str;
        int max_val = 0, max_index = 0, vow_count = 0, vow_index;
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //here we can see the open file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = System.IO.File.ReadAllText(openFileDialog1.FileName); //read text file from our string file s
                txtdisplay.Text = str.ToLower();//make it in lower
                string[] array = str.Split(' ');//split string with blank seperator
                txtfirstword.Text = array[0];//it is first word
                txtlastword.Text = array[array.Length - 1];//it is last word
                for (int i = 0; i < array.Length - 1; i++)//here loop from start to end to make our appropriate output
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }
                    if (vow_count < VowelCount(array[i]))
                    {
                        vow_count = VowelCount(array[i]);
                        vow_index = i;
                    }
                }
                txtlongest.Text = array[max_index];//output dispaly
                txtvowel.Text = array[vow_index];//output dispaly
                System.IO.StreamWriter sw = new StreamWriter(Application.StartupPath + "\\write.txt");//Textfile write here
                sw.WriteLine("Converting in Lower ::" + txtdisplay.Text);//Textfile write here
                sw.WriteLine("First Word ::" + txtfirstword.Text);//Textfile write here
                sw.WriteLine("Last Word ::" + txtlastword.Text);//Textfile write here
                sw.WriteLine("Longest word ::" + txtlongest.Text);//Textfile write here
                sw.WriteLine("Longest Vowel Word ::" + txtvowel.Text);//Textfile write here
                sw.Close();
                MessageBox.Show("Text file is Created");//output display for message
            }

        }
        public int VowelCount(string sentence)//function for vowel count here
        {
            int vowels = 0;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u') || (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }

            }
            return vowels;
        }

        private void Form1_(object sender, EventArgs e)
        {

        }

        private void F_Click(object sender, EventArgs e)
        {
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 469);
            this.label5.Name = "label3";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Word";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 690);
            this.Controls.Add(txtvowel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlongest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlastword);
            this.Controls.Add(this.txtfirstword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Longest Word";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.btnSelect.Location = new System.Drawing.Point(231, 72);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(307, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Here";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lower Case :";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.openFileDialog1.FileName = "openFileDialog1";
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {
            this.txtdisplay.Location = new System.Drawing.Point(231, 123);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(516, 281);
            this.txtdisplay.TabIndex = 2;
        }

        private void lastword_Click(object sender, EventArgs e)
        {
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 511);
            this.label6.Name = "label4";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Word";
        }

        private void txtfirstword_TextChanged(object sender, EventArgs e)
        {
            this.txtfirstword.Location = new System.Drawing.Point(231, 469);
            this.txtfirstword.Name = "txtfirstword";
            this.txtfirstword.Size = new System.Drawing.Size(335, 20);
            this.txtfirstword.TabIndex = 6;
        }

        private void txtlastword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.txtlastword.Location = new System.Drawing.Point(231, 511);
            this.txtlastword.Name = "txtlastword";
            this.txtlastword.Size = new System.Drawing.Size(335, 20);
            this.txtlastword.TabIndex = 7;
        }

        private void txtlongest_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.txtlongest.Location = new System.Drawing.Point(231, 561);
            this.txtlongest.Name = "txtlongest";
            this.txtlongest.Size = new System.Drawing.Size(335, 20);
            this.txtlongest.TabIndex = 9;
        }

        private void txtvowel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.txtvowel.Location = new System.Drawing.Point(231, 611);
            this.txtvowel.Name = "txtvowel";
            this.txtvowel.Size = new System.Drawing.Size(335, 20);
            this.txtvowel.TabIndex = 11;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Longest Vowel";
        }
      
    }

}

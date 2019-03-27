namespace ARBC800
{
    partial class fSub2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Location = new System.Drawing.Point(510, 28);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 32);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt2.Location = new System.Drawing.Point(368, 54);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(126, 32);
            this.txt2.TabIndex = 10;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(368, 28);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(126, 20);
            this.txt1.TabIndex = 9;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(662, 28);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(105, 95);
            this.btnQNext.TabIndex = 8;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(195, 28);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(141, 316);
            this.lst2.TabIndex = 7;
            this.lst2.Click += new System.EventHandler(this.lst2_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(37, 28);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(141, 316);
            this.lst1.TabIndex = 6;
            this.lst1.Click += new System.EventHandler(this.lst1_Click);
            // 
            // fSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "fSub2";
            this.Text = "KOREAN500";
            this.Load += new System.EventHandler(this.fSub2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
    }
}
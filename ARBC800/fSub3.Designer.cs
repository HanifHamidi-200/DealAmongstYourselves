namespace ARBC800
{
    partial class fSub3
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
            this.btnOK.Location = new System.Drawing.Point(505, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 32);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt2.Location = new System.Drawing.Point(363, 57);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(126, 32);
            this.txt2.TabIndex = 16;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(363, 31);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(126, 20);
            this.txt1.TabIndex = 15;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(657, 31);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(105, 95);
            this.btnQNext.TabIndex = 14;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(190, 31);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(141, 316);
            this.lst2.TabIndex = 13;
            this.lst2.Click += new System.EventHandler(this.lst2_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(32, 31);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(141, 316);
            this.lst1.TabIndex = 12;
            this.lst1.Click += new System.EventHandler(this.lst1_Click);
            // 
            // fSub3
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
            this.Name = "fSub3";
            this.Text = "RUSSIAN1000";
            this.Load += new System.EventHandler(this.fSub3_Load);
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
namespace GUESTH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(428, 47);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(163, 32);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "LightingInstalled";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(428, 85);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(163, 32);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Joshua(I+II)";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(428, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(163, 32);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "AtlantisAtlantic";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(428, 123);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(163, 32);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "NumbersFrom";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Yellow;
            this.btn6.Location = new System.Drawing.Point(428, 237);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(163, 32);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "Arcadia(1+2)";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Yellow;
            this.btn5.Location = new System.Drawing.Point(428, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(163, 32);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "TitanTitanic";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(613, 47);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(161, 251);
            this.lst1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(938, 350);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "GUESTH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ListBox lst1;
    }
}


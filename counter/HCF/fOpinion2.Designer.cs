namespace HCF
{
    partial class fOpinion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOpinion2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(457, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 51);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "[1]";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(622, 28);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 51);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "[4]";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(512, 28);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 51);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "[2]";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.v);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(567, 28);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 51);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "[3]";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // fOpinion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 309);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fOpinion2";
            this.Text = "2ndOpinion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FOpinion2_FormClosing);
            this.Load += new System.EventHandler(this.FOpinion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}
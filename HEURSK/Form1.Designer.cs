namespace HEURSK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txta3 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txta5 = new System.Windows.Forms.TextBox();
            this.txta6 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txta4 = new System.Windows.Forms.TextBox();
            this.txta9 = new System.Windows.Forms.TextBox();
            this.txta8 = new System.Windows.Forms.TextBox();
            this.txta7 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.txta7);
            this.groupBox1.Controls.Add(this.txta8);
            this.groupBox1.Controls.Add(this.txta9);
            this.groupBox1.Controls.Add(this.txta4);
            this.groupBox1.Controls.Add(this.txta2);
            this.groupBox1.Controls.Add(this.txta6);
            this.groupBox1.Controls.Add(this.txta5);
            this.groupBox1.Controls.Add(this.txta1);
            this.groupBox1.Controls.Add(this.txta3);
            this.groupBox1.Controls.Add(this.lst1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(505, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtb1);
            this.groupBox2.Controls.Add(this.txtb2);
            this.groupBox2.Controls.Add(this.txtb3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(707, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 465);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 286);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "TYPE_A",
            "TYPE_B",
            "TYPE_C"});
            this.lst1.Location = new System.Drawing.Point(17, 19);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(153, 43);
            this.lst1.TabIndex = 2;
            this.lst1.Click += new System.EventHandler(this.lst1_Click);
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "TYPE_N";
            // 
            // txta3
            // 
            this.txta3.Location = new System.Drawing.Point(153, 406);
            this.txta3.Name = "txta3";
            this.txta3.Size = new System.Drawing.Size(81, 20);
            this.txta3.TabIndex = 3;
            // 
            // txta1
            // 
            this.txta1.Location = new System.Drawing.Point(66, 406);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(81, 20);
            this.txta1.TabIndex = 4;
            // 
            // txta5
            // 
            this.txta5.Location = new System.Drawing.Point(240, 406);
            this.txta5.Name = "txta5";
            this.txta5.Size = new System.Drawing.Size(81, 20);
            this.txta5.TabIndex = 5;
            // 
            // txta6
            // 
            this.txta6.Location = new System.Drawing.Point(327, 406);
            this.txta6.Name = "txta6";
            this.txta6.Size = new System.Drawing.Size(81, 20);
            this.txta6.TabIndex = 6;
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(153, 380);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(81, 20);
            this.txta2.TabIndex = 7;
            // 
            // txta4
            // 
            this.txta4.Location = new System.Drawing.Point(153, 432);
            this.txta4.Name = "txta4";
            this.txta4.Size = new System.Drawing.Size(81, 20);
            this.txta4.TabIndex = 8;
            // 
            // txta9
            // 
            this.txta9.Location = new System.Drawing.Point(542, 432);
            this.txta9.Name = "txta9";
            this.txta9.Size = new System.Drawing.Size(81, 20);
            this.txta9.TabIndex = 9;
            // 
            // txta8
            // 
            this.txta8.Location = new System.Drawing.Point(589, 406);
            this.txta8.Name = "txta8";
            this.txta8.Size = new System.Drawing.Size(81, 20);
            this.txta8.TabIndex = 10;
            // 
            // txta7
            // 
            this.txta7.Location = new System.Drawing.Point(502, 406);
            this.txta7.Name = "txta7";
            this.txta7.Size = new System.Drawing.Size(81, 20);
            this.txta7.TabIndex = 11;
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(6, 406);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(81, 20);
            this.txtb1.TabIndex = 14;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(93, 406);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(81, 20);
            this.txtb2.TabIndex = 13;
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(46, 432);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(81, 20);
            this.txtb3.TabIndex = 12;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(920, 36);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(89, 93);
            this.btnQNext.TabIndex = 2;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(920, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 93);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 513);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "HEURSKPersonnel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txta7;
        private System.Windows.Forms.TextBox txta8;
        private System.Windows.Forms.TextBox txta9;
        private System.Windows.Forms.TextBox txta4;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.TextBox txta6;
        private System.Windows.Forms.TextBox txta5;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.TextBox txta3;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Button btnSave;
    }
}


﻿namespace HCF
{
    partial class fMSub1
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl56 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(12, 22);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(94, 225);
            this.lst1.TabIndex = 0;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(112, 22);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(94, 225);
            this.lst2.TabIndex = 1;
            this.lst2.Click += new System.EventHandler(this.Lst2_Click);
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(229, 22);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(107, 69);
            this.btnQNext.TabIndex = 2;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.BtnQNext_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnView.Location = new System.Drawing.Point(342, 22);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 69);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "view";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl14);
            this.panel1.Controls.Add(this.lbl13);
            this.panel1.Controls.Add(this.lbl12);
            this.panel1.Controls.Add(this.lbl11);
            this.panel1.Controls.Add(this.lbl10);
            this.panel1.Controls.Add(this.lbl9);
            this.panel1.Controls.Add(this.lbl8);
            this.panel1.Controls.Add(this.lbl7);
            this.panel1.Controls.Add(this.lbl56);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Location = new System.Drawing.Point(229, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 233);
            this.panel1.TabIndex = 4;
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.BackColor = System.Drawing.Color.Yellow;
            this.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl14.Location = new System.Drawing.Point(21, 182);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(139, 15);
            this.lbl14.TabIndex = 9;
            this.lbl14.Text = "Probability(PopularUsage) =";
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.BackColor = System.Drawing.Color.Yellow;
            this.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl13.Location = new System.Drawing.Point(21, 167);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(130, 15);
            this.lbl13.TabIndex = 8;
            this.lbl13.Text = "Probabilty(Manufacture) =";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Yellow;
            this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12.Location = new System.Drawing.Point(21, 152);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(142, 15);
            this.lbl12.TabIndex = 7;
            this.lbl12.Text = "Probabilty(FeasibilityStudy) =";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Yellow;
            this.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl11.Location = new System.Drawing.Point(21, 124);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(124, 15);
            this.lbl11.TabIndex = 6;
            this.lbl11.Text = "Possibility(NaOH) = false";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Yellow;
            this.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl10.Location = new System.Drawing.Point(21, 112);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(129, 15);
            this.lbl10.TabIndex = 5;
            this.lbl10.Text = "Possibility(H2SO4) = false";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.Yellow;
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl9.Location = new System.Drawing.Point(21, 97);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(111, 15);
            this.lbl9.TabIndex = 4;
            this.lbl9.Text = "Possibility(HCl) = false";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Yellow;
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Location = new System.Drawing.Point(21, 82);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(108, 15);
            this.lbl8.TabIndex = 3;
            this.lbl8.Text = "Possibility(O2) = false";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.Yellow;
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Location = new System.Drawing.Point(21, 67);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(114, 15);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = "Possibility(H20) = false";
            // 
            // lbl56
            // 
            this.lbl56.AutoSize = true;
            this.lbl56.BackColor = System.Drawing.Color.Yellow;
            this.lbl56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl56.Location = new System.Drawing.Point(21, 42);
            this.lbl56.Name = "lbl56";
            this.lbl56.Size = new System.Drawing.Size(93, 15);
            this.lbl56.TabIndex = 1;
            this.lbl56.Text = "200g reactswith ?";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Yellow;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Location = new System.Drawing.Point(21, 14);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 15);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "combination = Li2O";
            // 
            // fMSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "fMSub1";
            this.Text = "DatabaseLookup";
            this.Load += new System.EventHandler(this.FMSub1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl56;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl14;
    }
}
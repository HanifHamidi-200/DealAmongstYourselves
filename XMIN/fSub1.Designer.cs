﻿namespace XMIN
{
    partial class fSub1
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
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.btnOpen5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(12, 120);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(195, 42);
            this.btnOpen3.TabIndex = 5;
            this.btnOpen3.Text = "TODOLS";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.BtnOpen3_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(12, 72);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(195, 42);
            this.btnOpen2.TabIndex = 4;
            this.btnOpen2.Text = "ICOITN";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(12, 24);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(195, 42);
            this.btnOpen1.TabIndex = 3;
            this.btnOpen1.Text = "LACBOX";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.BtnOpen1_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(10, 168);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(195, 42);
            this.btnOpen4.TabIndex = 6;
            this.btnOpen4.Text = "MSTORE2";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.BtnOpen4_Click);
            // 
            // btnOpen5
            // 
            this.btnOpen5.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen5.Location = new System.Drawing.Point(10, 216);
            this.btnOpen5.Name = "btnOpen5";
            this.btnOpen5.Size = new System.Drawing.Size(195, 42);
            this.btnOpen5.TabIndex = 7;
            this.btnOpen5.Text = "KEYPAD";
            this.btnOpen5.UseVisualStyleBackColor = false;
            this.btnOpen5.Click += new System.EventHandler(this.BtnOpen5_Click);
            // 
            // fSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 301);
            this.Controls.Add(this.btnOpen5);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "fSub1";
            this.Text = "XMIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnOpen5;
    }
}
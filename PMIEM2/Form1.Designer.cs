﻿namespace PMIEM2
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
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.btnOpen5 = new System.Windows.Forms.Button();
            this.btnOpen6 = new System.Windows.Forms.Button();
            this.btnOpen7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(12, 28);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(203, 39);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "ClickGrid";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(12, 73);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(203, 39);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "NavGrid";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(12, 118);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(203, 39);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "SaveFile";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.BtnOpen3_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(12, 163);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(203, 39);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "ICOITN";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.BtnOpen4_Click);
            // 
            // btnOpen5
            // 
            this.btnOpen5.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen5.Location = new System.Drawing.Point(12, 208);
            this.btnOpen5.Name = "btnOpen5";
            this.btnOpen5.Size = new System.Drawing.Size(203, 39);
            this.btnOpen5.TabIndex = 4;
            this.btnOpen5.Text = "TimerControl";
            this.btnOpen5.UseVisualStyleBackColor = false;
            this.btnOpen5.Click += new System.EventHandler(this.BtnOpen5_Click);
            // 
            // btnOpen6
            // 
            this.btnOpen6.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen6.Location = new System.Drawing.Point(12, 253);
            this.btnOpen6.Name = "btnOpen6";
            this.btnOpen6.Size = new System.Drawing.Size(203, 39);
            this.btnOpen6.TabIndex = 5;
            this.btnOpen6.Text = "PrintDialog";
            this.btnOpen6.UseVisualStyleBackColor = false;
            this.btnOpen6.Click += new System.EventHandler(this.btnOpen6_Click);
            // 
            // btnOpen7
            // 
            this.btnOpen7.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen7.Location = new System.Drawing.Point(12, 298);
            this.btnOpen7.Name = "btnOpen7";
            this.btnOpen7.Size = new System.Drawing.Size(203, 39);
            this.btnOpen7.TabIndex = 6;
            this.btnOpen7.Text = "WaveDialog";
            this.btnOpen7.UseVisualStyleBackColor = false;
            this.btnOpen7.Click += new System.EventHandler(this.BtnOpen7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 376);
            this.Controls.Add(this.btnOpen7);
            this.Controls.Add(this.btnOpen6);
            this.Controls.Add(this.btnOpen5);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "PMIEM2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnOpen5;
        private System.Windows.Forms.Button btnOpen6;
        private System.Windows.Forms.Button btnOpen7;
    }
}


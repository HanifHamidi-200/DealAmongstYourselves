namespace MAZERN
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
            this.btnDefine1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.btnDefine2 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(26, 41);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(196, 38);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "PassingShadow";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.BtnOpen1_Click);
            // 
            // btnDefine1
            // 
            this.btnDefine1.BackColor = System.Drawing.Color.Yellow;
            this.btnDefine1.Location = new System.Drawing.Point(228, 41);
            this.btnDefine1.Name = "btnDefine1";
            this.btnDefine1.Size = new System.Drawing.Size(92, 38);
            this.btnDefine1.TabIndex = 1;
            this.btnDefine1.Text = "DFSet1";
            this.btnDefine1.UseVisualStyleBackColor = false;
            this.btnDefine1.Click += new System.EventHandler(this.BtnDefine1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay1.Location = new System.Drawing.Point(326, 41);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(92, 38);
            this.btnPlay1.TabIndex = 2;
            this.btnPlay1.Text = "Play1";
            this.btnPlay1.UseVisualStyleBackColor = false;
            this.btnPlay1.Click += new System.EventHandler(this.BtnPlay1_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay2.Location = new System.Drawing.Point(326, 108);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(92, 38);
            this.btnPlay2.TabIndex = 5;
            this.btnPlay2.Text = "Play2";
            this.btnPlay2.UseVisualStyleBackColor = false;
            this.btnPlay2.Click += new System.EventHandler(this.BtnPlay2_Click);
            // 
            // btnDefine2
            // 
            this.btnDefine2.BackColor = System.Drawing.Color.Yellow;
            this.btnDefine2.Location = new System.Drawing.Point(228, 108);
            this.btnDefine2.Name = "btnDefine2";
            this.btnDefine2.Size = new System.Drawing.Size(92, 38);
            this.btnDefine2.TabIndex = 4;
            this.btnDefine2.Text = "DFSet2";
            this.btnDefine2.UseVisualStyleBackColor = false;
            this.btnDefine2.Click += new System.EventHandler(this.BtnDefine2_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(26, 108);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(196, 38);
            this.btnOpen2.TabIndex = 3;
            this.btnOpen2.Text = "ImagineryWalls";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 197);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnDefine2);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.btnDefine1);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "MAZERN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnDefine1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Button btnDefine2;
        private System.Windows.Forms.Button btnOpen2;
    }
}


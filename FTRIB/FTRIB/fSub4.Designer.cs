namespace FTRIB
{
    partial class fSub4
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.txt2 = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.RichTextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(123, 52);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 31);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Triangle";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(123, 89);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(193, 91);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(406, 209);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(193, 91);
            this.txt2.TabIndex = 3;
            this.txt2.Text = "";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(406, 172);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 31);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Coin";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(123, 347);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(193, 91);
            this.txt3.TabIndex = 5;
            this.txt3.Text = "";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(123, 310);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 31);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Trapezium";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // fSub4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Name = "fSub4";
            this.Text = "MCHYPL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox txt1;
        private System.Windows.Forms.RichTextBox txt2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.RichTextBox txt3;
        private System.Windows.Forms.Button btn3;
    }
}
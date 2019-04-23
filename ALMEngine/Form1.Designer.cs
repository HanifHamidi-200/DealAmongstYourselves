namespace ALMEngine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.lst3 = new System.Windows.Forms.ListBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.lst4 = new System.Windows.Forms.ListBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lst1);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MostRecentPrograms";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(18, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(105, 53);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "MostRecent\r\nPrograms";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(18, 87);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(192, 134);
            this.lst1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lst4);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.lst3);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.lst2);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Location = new System.Drawing.Point(15, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Others";
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(18, 87);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(192, 134);
            this.lst2.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(18, 28);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(105, 53);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "CategoryVersatile";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // lst3
            // 
            this.lst3.FormattingEnabled = true;
            this.lst3.Location = new System.Drawing.Point(233, 87);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(192, 134);
            this.lst3.TabIndex = 3;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(233, 28);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(105, 53);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "CategoryFeasible";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // lst4
            // 
            this.lst4.FormattingEnabled = true;
            this.lst4.Location = new System.Drawing.Point(457, 87);
            this.lst4.Name = "lst4";
            this.lst4.Size = new System.Drawing.Size(192, 134);
            this.lst4.TabIndex = 5;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(457, 28);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(105, 53);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "CategoryNuwark";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ALMEngine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst4;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.ListBox lst3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btn2;
    }
}


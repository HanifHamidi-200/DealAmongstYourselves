namespace ARBC800
{
    partial class fShow
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
            this.lst3 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 25;
            this.lst1.Location = new System.Drawing.Point(12, 32);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(215, 379);
            this.lst1.TabIndex = 0;
            // 
            // lst3
            // 
            this.lst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst3.FormattingEnabled = true;
            this.lst3.ItemHeight = 25;
            this.lst3.Location = new System.Drawing.Point(454, 32);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(215, 379);
            this.lst3.TabIndex = 1;
            // 
            // lst2
            // 
            this.lst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 25;
            this.lst2.Location = new System.Drawing.Point(233, 32);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(215, 379);
            this.lst2.TabIndex = 1;
            // 
            // lst4
            // 
            this.lst4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst4.FormattingEnabled = true;
            this.lst4.ItemHeight = 25;
            this.lst4.Location = new System.Drawing.Point(675, 32);
            this.lst4.Name = "lst4";
            this.lst4.Size = new System.Drawing.Size(215, 379);
            this.lst4.TabIndex = 2;
            // 
            // fShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.lst4);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.lst1);
            this.Name = "fShow";
            this.Text = "fShow";
            this.Load += new System.EventHandler(this.fShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst3;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst4;
    }
}
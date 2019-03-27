namespace PLUMG
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
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picIn1 = new System.Windows.Forms.PictureBox();
            this.picIn2 = new System.Windows.Forms.PictureBox();
            this.picIn4 = new System.Windows.Forms.PictureBox();
            this.picIn3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnQNext = new System.Windows.Forms.Button();
            this.lblIn1 = new System.Windows.Forms.Label();
            this.lblIn2 = new System.Windows.Forms.Label();
            this.lblIn4 = new System.Windows.Forms.Label();
            this.lblIn3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOut3 = new System.Windows.Forms.Label();
            this.lblOut4 = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.picOut2 = new System.Windows.Forms.PictureBox();
            this.picOut1 = new System.Windows.Forms.PictureBox();
            this.picOut3 = new System.Windows.Forms.PictureBox();
            this.picOut4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn3)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackColor = System.Drawing.Color.Yellow;
            this.btnSnapshot.Location = new System.Drawing.Point(12, 56);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(124, 34);
            this.btnSnapshot.TabIndex = 0;
            this.btnSnapshot.Text = "&Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = false;
            this.btnSnapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblIn3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picIn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picIn1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picIn3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.picIn2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.34188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 249);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // picIn1
            // 
            this.picIn1.Image = ((System.Drawing.Image)(resources.GetObject("picIn1.Image")));
            this.picIn1.Location = new System.Drawing.Point(3, 26);
            this.picIn1.Name = "picIn1";
            this.picIn1.Size = new System.Drawing.Size(69, 81);
            this.picIn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIn1.TabIndex = 0;
            this.picIn1.TabStop = false;
            this.picIn1.Click += new System.EventHandler(this.PicIn1_Click);
            // 
            // picIn2
            // 
            this.picIn2.Image = ((System.Drawing.Image)(resources.GetObject("picIn2.Image")));
            this.picIn2.Location = new System.Drawing.Point(109, 26);
            this.picIn2.Name = "picIn2";
            this.picIn2.Size = new System.Drawing.Size(69, 81);
            this.picIn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIn2.TabIndex = 1;
            this.picIn2.TabStop = false;
            this.picIn2.Click += new System.EventHandler(this.PicIn2_Click);
            // 
            // picIn4
            // 
            this.picIn4.Image = ((System.Drawing.Image)(resources.GetObject("picIn4.Image")));
            this.picIn4.Location = new System.Drawing.Point(3, 120);
            this.picIn4.Name = "picIn4";
            this.picIn4.Size = new System.Drawing.Size(69, 81);
            this.picIn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIn4.TabIndex = 2;
            this.picIn4.TabStop = false;
            this.picIn4.Click += new System.EventHandler(this.PicIn4_Click);
            // 
            // picIn3
            // 
            this.picIn3.Image = ((System.Drawing.Image)(resources.GetObject("picIn3.Image")));
            this.picIn3.Location = new System.Drawing.Point(109, 120);
            this.picIn3.Name = "picIn3";
            this.picIn3.Size = new System.Drawing.Size(69, 81);
            this.picIn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIn3.TabIndex = 3;
            this.picIn3.TabStop = false;
            this.picIn3.Click += new System.EventHandler(this.PicIn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(390, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "OUT";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDone,
            this.lblPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPoints.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(126, 19);
            this.lblPoints.Text = "PointsCollected = 213";
            // 
            // lblDone
            // 
            this.lblDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDone.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(76, 19);
            this.lblDone.Text = "Done = 3/12";
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(684, 56);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(89, 99);
            this.btnQNext.TabIndex = 6;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.BtnQNext_Click);
            // 
            // lblIn1
            // 
            this.lblIn1.AutoSize = true;
            this.lblIn1.BackColor = System.Drawing.Color.Yellow;
            this.lblIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIn1.Location = new System.Drawing.Point(3, 0);
            this.lblIn1.Name = "lblIn1";
            this.lblIn1.Size = new System.Drawing.Size(20, 15);
            this.lblIn1.TabIndex = 7;
            this.lblIn1.Text = "IN";
            // 
            // lblIn2
            // 
            this.lblIn2.AutoSize = true;
            this.lblIn2.BackColor = System.Drawing.Color.Yellow;
            this.lblIn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIn2.Location = new System.Drawing.Point(109, 0);
            this.lblIn2.Name = "lblIn2";
            this.lblIn2.Size = new System.Drawing.Size(20, 15);
            this.lblIn2.TabIndex = 8;
            this.lblIn2.Text = "IN";
            // 
            // lblIn4
            // 
            this.lblIn4.AutoSize = true;
            this.lblIn4.BackColor = System.Drawing.Color.Yellow;
            this.lblIn4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIn4.Location = new System.Drawing.Point(3, 228);
            this.lblIn4.Name = "lblIn4";
            this.lblIn4.Size = new System.Drawing.Size(20, 15);
            this.lblIn4.TabIndex = 9;
            this.lblIn4.Text = "IN";
            // 
            // lblIn3
            // 
            this.lblIn3.AutoSize = true;
            this.lblIn3.BackColor = System.Drawing.Color.Yellow;
            this.lblIn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIn3.Location = new System.Drawing.Point(109, 228);
            this.lblIn3.Name = "lblIn3";
            this.lblIn3.Size = new System.Drawing.Size(20, 15);
            this.lblIn3.TabIndex = 10;
            this.lblIn3.Text = "IN";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblOut3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblOut4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblOut2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOut1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picOut2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.picOut1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.picOut3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.picOut4, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(390, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65812F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.34188F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 249);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblOut3
            // 
            this.lblOut3.AutoSize = true;
            this.lblOut3.BackColor = System.Drawing.Color.Yellow;
            this.lblOut3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut3.Location = new System.Drawing.Point(109, 228);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(32, 15);
            this.lblOut3.TabIndex = 10;
            this.lblOut3.Text = "OUT";
            // 
            // lblOut4
            // 
            this.lblOut4.AutoSize = true;
            this.lblOut4.BackColor = System.Drawing.Color.Yellow;
            this.lblOut4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut4.Location = new System.Drawing.Point(3, 228);
            this.lblOut4.Name = "lblOut4";
            this.lblOut4.Size = new System.Drawing.Size(32, 15);
            this.lblOut4.TabIndex = 9;
            this.lblOut4.Text = "OUT";
            // 
            // lblOut2
            // 
            this.lblOut2.AutoSize = true;
            this.lblOut2.BackColor = System.Drawing.Color.Yellow;
            this.lblOut2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut2.Location = new System.Drawing.Point(109, 0);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(32, 15);
            this.lblOut2.TabIndex = 8;
            this.lblOut2.Text = "OUT";
            // 
            // lblOut1
            // 
            this.lblOut1.AutoSize = true;
            this.lblOut1.BackColor = System.Drawing.Color.Yellow;
            this.lblOut1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut1.Location = new System.Drawing.Point(3, 0);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(32, 15);
            this.lblOut1.TabIndex = 7;
            this.lblOut1.Text = "OUT";
            // 
            // picOut2
            // 
            this.picOut2.Image = ((System.Drawing.Image)(resources.GetObject("picOut2.Image")));
            this.picOut2.Location = new System.Drawing.Point(109, 26);
            this.picOut2.Name = "picOut2";
            this.picOut2.Size = new System.Drawing.Size(69, 81);
            this.picOut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOut2.TabIndex = 3;
            this.picOut2.TabStop = false;
            // 
            // picOut1
            // 
            this.picOut1.Image = ((System.Drawing.Image)(resources.GetObject("picOut1.Image")));
            this.picOut1.Location = new System.Drawing.Point(3, 26);
            this.picOut1.Name = "picOut1";
            this.picOut1.Size = new System.Drawing.Size(69, 81);
            this.picOut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOut1.TabIndex = 2;
            this.picOut1.TabStop = false;
            // 
            // picOut3
            // 
            this.picOut3.Image = ((System.Drawing.Image)(resources.GetObject("picOut3.Image")));
            this.picOut3.Location = new System.Drawing.Point(109, 120);
            this.picOut3.Name = "picOut3";
            this.picOut3.Size = new System.Drawing.Size(69, 81);
            this.picOut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOut3.TabIndex = 1;
            this.picOut3.TabStop = false;
            // 
            // picOut4
            // 
            this.picOut4.Image = ((System.Drawing.Image)(resources.GetObject("picOut4.Image")));
            this.picOut4.Location = new System.Drawing.Point(3, 120);
            this.picOut4.Name = "picOut4";
            this.picOut4.Size = new System.Drawing.Size(69, 81);
            this.picOut4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOut4.TabIndex = 0;
            this.picOut4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 368);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSnapshot);
            this.Name = "Form1";
            this.Text = "PLUMG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIn3)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIn3;
        private System.Windows.Forms.Label lblIn4;
        private System.Windows.Forms.Label lblIn2;
        private System.Windows.Forms.Label lblIn1;
        private System.Windows.Forms.PictureBox picIn4;
        private System.Windows.Forms.PictureBox picIn1;
        private System.Windows.Forms.PictureBox picIn3;
        private System.Windows.Forms.PictureBox picIn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDone;
        private System.Windows.Forms.ToolStripStatusLabel lblPoints;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblOut3;
        private System.Windows.Forms.Label lblOut4;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.PictureBox picOut2;
        private System.Windows.Forms.PictureBox picOut1;
        private System.Windows.Forms.PictureBox picOut3;
        private System.Windows.Forms.PictureBox picOut4;
    }
}


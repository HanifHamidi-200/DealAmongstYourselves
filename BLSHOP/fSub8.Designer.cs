namespace BLSHOP
{
    partial class fSub8
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "AeroplaneLanding",
            "AeroplaneRunway",
            "AirspacePorting",
            "BTSDealPorting",
            "CropEquipment/Plowing",
            "DatabaseFirst_JobFirst",
            "DDayLandings_ConstructionTheorem",
            "FloursAndResins",
            "FTTW",
            "GreatMinds",
            "HenryFord[Vs]Ford",
            "HiImCortana",
            "HorseMachine",
            "IchNachtMusik",
            "ManualOfElectronics",
            "NPROPH",
            "PortConsequence[Vs]HillyBilly",
            "PropertyLadder/ProgressReport",
            "SputnikNarcissusTakeover"});
            this.listBox1.Location = new System.Drawing.Point(58, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 355);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // fSub8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Name = "fSub8";
            this.Text = "OsakaBT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}
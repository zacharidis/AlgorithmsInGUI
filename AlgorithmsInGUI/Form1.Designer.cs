namespace AlgorithmsInGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpbCollection = new System.Windows.Forms.GroupBox();
            this.grpbResults = new System.Windows.Forms.GroupBox();
            this.btnFizz = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpbCollection.SuspendLayout();
            this.grpbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 456);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(96, 36);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpbCollection
            // 
            this.grpbCollection.Controls.Add(this.btnFizz);
            this.grpbCollection.Location = new System.Drawing.Point(16, 17);
            this.grpbCollection.Name = "grpbCollection";
            this.grpbCollection.Size = new System.Drawing.Size(432, 429);
            this.grpbCollection.TabIndex = 1;
            this.grpbCollection.TabStop = false;
            this.grpbCollection.Text = "Collection ";
            // 
            // grpbResults
            // 
            this.grpbResults.Controls.Add(this.lstResults);
            this.grpbResults.Location = new System.Drawing.Point(470, 17);
            this.grpbResults.Name = "grpbResults";
            this.grpbResults.Size = new System.Drawing.Size(434, 429);
            this.grpbResults.TabIndex = 2;
            this.grpbResults.TabStop = false;
            this.grpbResults.Text = "Results";
            // 
            // btnFizz
            // 
            this.btnFizz.Location = new System.Drawing.Point(10, 31);
            this.btnFizz.Name = "btnFizz";
            this.btnFizz.Size = new System.Drawing.Size(82, 28);
            this.btnFizz.TabIndex = 0;
            this.btnFizz.Text = "FizzBuzz";
            this.btnFizz.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 15;
            this.lstResults.Location = new System.Drawing.Point(17, 27);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(405, 379);
            this.lstResults.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 504);
            this.Controls.Add(this.grpbResults);
            this.Controls.Add(this.grpbCollection);
            this.Controls.Add(this.btnAbout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Algorithms And Problems in a GUI , By Georgios Zacharidis";
            this.grpbCollection.ResumeLayout(false);
            this.grpbResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbout;
        private GroupBox grpbCollection;
        private Button btnFizz;
        private GroupBox grpbResults;
        private ListBox lstResults;
    }
}
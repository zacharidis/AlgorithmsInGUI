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
            this.btnPrimes = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.btnFizz = new System.Windows.Forms.Button();
            this.grpbResults = new System.Windows.Forms.GroupBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpbInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpbCollection.SuspendLayout();
            this.grpbResults.SuspendLayout();
            this.grpbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(248, 400);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(96, 36);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpbCollection
            // 
            this.grpbCollection.Controls.Add(this.btnPrimes);
            this.grpbCollection.Controls.Add(this.btnFactorial);
            this.grpbCollection.Controls.Add(this.btnPow);
            this.grpbCollection.Controls.Add(this.btnPalindrome);
            this.grpbCollection.Controls.Add(this.btnFizz);
            this.grpbCollection.Location = new System.Drawing.Point(16, 17);
            this.grpbCollection.Name = "grpbCollection";
            this.grpbCollection.Size = new System.Drawing.Size(328, 329);
            this.grpbCollection.TabIndex = 1;
            this.grpbCollection.TabStop = false;
            this.grpbCollection.Text = "Collection ";
            // 
            // btnPrimes
            // 
            this.btnPrimes.Location = new System.Drawing.Point(10, 163);
            this.btnPrimes.Name = "btnPrimes";
            this.btnPrimes.Size = new System.Drawing.Size(95, 25);
            this.btnPrimes.TabIndex = 4;
            this.btnPrimes.Text = "Primes Range";
            this.btnPrimes.UseVisualStyleBackColor = true;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(10, 131);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(95, 26);
            this.btnFactorial.TabIndex = 3;
            this.btnFactorial.Text = "Factorial (1..n)";
            this.btnFactorial.UseVisualStyleBackColor = true;
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(10, 99);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(95, 26);
            this.btnPow.TabIndex = 2;
            this.btnPow.Text = "Power (x , n)";
            this.btnPow.UseVisualStyleBackColor = true;
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(10, 65);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(95, 28);
            this.btnPalindrome.TabIndex = 1;
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            // 
            // btnFizz
            // 
            this.btnFizz.Location = new System.Drawing.Point(10, 31);
            this.btnFizz.Name = "btnFizz";
            this.btnFizz.Size = new System.Drawing.Size(95, 28);
            this.btnFizz.TabIndex = 0;
            this.btnFizz.Text = "FizzBuzz";
            this.btnFizz.UseVisualStyleBackColor = true;
            this.btnFizz.Click += new System.EventHandler(this.btnFizz_Click);
            // 
            // grpbResults
            // 
            this.grpbResults.Controls.Add(this.lstResults);
            this.grpbResults.Location = new System.Drawing.Point(350, 17);
            this.grpbResults.Name = "grpbResults";
            this.grpbResults.Size = new System.Drawing.Size(777, 419);
            this.grpbResults.TabIndex = 2;
            this.grpbResults.TabStop = false;
            this.grpbResults.Text = "Results";
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.ItemHeight = 21;
            this.lstResults.Location = new System.Drawing.Point(17, 27);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(754, 382);
            this.lstResults.TabIndex = 0;
            // 
            // grpbInput
            // 
            this.grpbInput.Controls.Add(this.txtInput);
            this.grpbInput.Location = new System.Drawing.Point(18, 359);
            this.grpbInput.Name = "grpbInput";
            this.grpbInput.Size = new System.Drawing.Size(164, 77);
            this.grpbInput.TabIndex = 3;
            this.grpbInput.TabStop = false;
            this.grpbInput.Text = "Input Value";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(136, 23);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "15";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.grpbInput);
            this.Controls.Add(this.grpbResults);
            this.Controls.Add(this.grpbCollection);
            this.Controls.Add(this.btnAbout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Algorithms And Problems in a GUI , By Georgios Zacharidis";
            this.grpbCollection.ResumeLayout(false);
            this.grpbResults.ResumeLayout(false);
            this.grpbInput.ResumeLayout(false);
            this.grpbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbout;
        private GroupBox grpbCollection;
        private Button btnFizz;
        private GroupBox grpbResults;
        private ListBox lstResults;
        private Button btnPow;
        private Button btnPalindrome;
        private GroupBox grpbInput;
        private Button btnPrimes;
        private Button btnFactorial;
        private TextBox txtInput;
    }
}
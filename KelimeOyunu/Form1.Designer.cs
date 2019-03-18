namespace KelimeOyunu
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lblWordsFound = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 20;
            this.lbProducts.Location = new System.Drawing.Point(44, 118);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(240, 284);
            this.lbProducts.TabIndex = 0;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuess.Location = new System.Drawing.Point(365, 41);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(235, 27);
            this.txtGuess.TabIndex = 1;
            // 
            // lbResults
            // 
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 22;
            this.lbResults.Location = new System.Drawing.Point(353, 118);
            this.lbResults.Margin = new System.Windows.Forms.Padding(4);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(358, 378);
            this.lbResults.TabIndex = 2;
            // 
            // lblWordsFound
            // 
            this.lblWordsFound.AutoSize = true;
            this.lblWordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWordsFound.Location = new System.Drawing.Point(348, 545);
            this.lblWordsFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordsFound.Name = "lblWordsFound";
            this.lblWordsFound.Size = new System.Drawing.Size(31, 25);
            this.lblWordsFound.TabIndex = 3;
            this.lblWordsFound.Text = " --";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(626, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWordsFound);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lbProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lblWordsFound;
        private System.Windows.Forms.Button button1;
    }
}


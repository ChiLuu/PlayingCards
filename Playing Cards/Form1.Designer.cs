namespace Playing_Cards
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
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.ItemHeight = 18;
            this.lstDeck.Location = new System.Drawing.Point(316, 33);
            this.lstDeck.Margin = new System.Windows.Forms.Padding(4);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(205, 832);
            this.lstDeck.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(81, 33);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(140, 49);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 911);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lstDeck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeck;
        private System.Windows.Forms.Button btnShuffle;
    }
}


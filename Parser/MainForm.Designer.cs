namespace Parser
{
    partial class MainForm
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
            this.StartPage = new System.Windows.Forms.NumericUpDown();
            this.EndPage = new System.Windows.Forms.NumericUpDown();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndPage)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPage
            // 
            this.StartPage.Location = new System.Drawing.Point(604, 38);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(89, 22);
            this.StartPage.TabIndex = 1;
            // 
            // EndPage
            // 
            this.EndPage.Location = new System.Drawing.Point(604, 93);
            this.EndPage.Name = "EndPage";
            this.EndPage.Size = new System.Drawing.Size(88, 22);
            this.EndPage.TabIndex = 2;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(578, 11);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(38, 17);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "Start";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(578, 73);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(33, 17);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "End";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(591, 191);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 37);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(591, 259);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(152, 37);
            this.AbortButton.TabIndex = 6;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 16;
            this.ResultBox.Location = new System.Drawing.Point(25, 25);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(490, 516);
            this.ResultBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 577);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.EndPage);
            this.Controls.Add(this.StartPage);
            this.Name = "MainForm";
            this.Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown StartPage;
        private System.Windows.Forms.NumericUpDown EndPage;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.ListBox ResultBox;
    }
}


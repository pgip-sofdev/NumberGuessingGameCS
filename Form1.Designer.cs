namespace numberGuessingGame
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.ngButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type your guess here(1-1000):";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(36, 81);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(256, 49);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // ngButton
            // 
            this.ngButton.Location = new System.Drawing.Point(36, 147);
            this.ngButton.Name = "ngButton";
            this.ngButton.Size = new System.Drawing.Size(256, 50);
            this.ngButton.TabIndex = 3;
            this.ngButton.Text = "New Game";
            this.ngButton.UseVisualStyleBackColor = true;
            this.ngButton.Click += new System.EventHandler(this.ngButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Location = new System.Drawing.Point(141, 62);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(45, 13);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 209);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ngButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button ngButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultBox;
    }
}


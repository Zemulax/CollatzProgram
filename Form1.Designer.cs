namespace CollatzProgram1
{
    partial class Collatz
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
            this.Start = new System.Windows.Forms.Button();
            this.Display1 = new System.Windows.Forms.Panel();
            this.Display2 = new System.Windows.Forms.Label();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.PrizeText = new System.Windows.Forms.Label();
            this.Display1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.SystemColors.Control;
            this.Start.Location = new System.Drawing.Point(373, 501);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(148, 35);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Display1
            // 
            this.Display1.AutoScroll = true;
            this.Display1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Display1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Display1.Controls.Add(this.Display2);
            this.Display1.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Display1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display1.Location = new System.Drawing.Point(46, 36);
            this.Display1.Name = "Display1";
            this.Display1.Size = new System.Drawing.Size(475, 459);
            this.Display1.TabIndex = 2;
            // 
            // Display2
            // 
            this.Display2.AutoSize = true;
            this.Display2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Display2.Location = new System.Drawing.Point(12, 15);
            this.Display2.Name = "Display2";
            this.Display2.Size = new System.Drawing.Size(406, 24);
            this.Display2.TabIndex = 0;
            this.Display2.Text = "The process log will appear here!";
            // 
            // Progressbar
            // 
            this.Progressbar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Progressbar.Location = new System.Drawing.Point(527, 36);
            this.Progressbar.MarqueeAnimationSpeed = 10;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(359, 29);
            this.Progressbar.Step = 1;
            this.Progressbar.TabIndex = 3;
            this.Progressbar.Click += new System.EventHandler(this.Progressbar_Click);
            // 
            // NumberInput
            // 
            this.NumberInput.AcceptsReturn = true;
            this.NumberInput.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberInput.Location = new System.Drawing.Point(46, 501);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.PlaceholderText = "123";
            this.NumberInput.Size = new System.Drawing.Size(321, 35);
            this.NumberInput.TabIndex = 4;
            // 
            // PrizeText
            // 
            this.PrizeText.AutoSize = true;
            this.PrizeText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrizeText.Font = new System.Drawing.Font("Unispace", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizeText.ForeColor = System.Drawing.Color.Gold;
            this.PrizeText.Location = new System.Drawing.Point(527, 139);
            this.PrizeText.Name = "PrizeText";
            this.PrizeText.Size = new System.Drawing.Size(397, 40);
            this.PrizeText.TabIndex = 5;
            this.PrizeText.Text = "$1 MILLION AWAITS! ";
            this.PrizeText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Collatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(923, 548);
            this.Controls.Add(this.PrizeText);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.Display1);
            this.Controls.Add(this.Start);
            this.Name = "Collatz";
            this.Text = "Collatz";
            this.Display1.ResumeLayout(false);
            this.Display1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start;
        private Panel Display1;
        private Label Display2;
        private ProgressBar Progressbar;
        private TextBox NumberInput;
        private Label PrizeText;
    }
}
namespace bettingSimulator
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
            this.gamePicker = new System.Windows.Forms.ComboBox();
            this.betBox = new System.Windows.Forms.TextBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.gameElement1 = new System.Windows.Forms.Label();
            this.gameElement2 = new System.Windows.Forms.Label();
            this.gameElement3 = new System.Windows.Forms.Label();
            this.gameElement4 = new System.Windows.Forms.Label();
            this.gameElement5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.commitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.pickGameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePicker
            // 
            this.gamePicker.FormattingEnabled = true;
            this.gamePicker.Items.AddRange(new object[] {
            "Powerball",
            "Poker",
            "Horse Racing"});
            this.gamePicker.Location = new System.Drawing.Point(12, 314);
            this.gamePicker.Name = "gamePicker";
            this.gamePicker.Size = new System.Drawing.Size(121, 21);
            this.gamePicker.TabIndex = 0;
            this.gamePicker.SelectedIndexChanged += new System.EventHandler(this.gamePicker_SelectedIndexChanged);
            // 
            // betBox
            // 
            this.betBox.Location = new System.Drawing.Point(44, 254);
            this.betBox.Name = "betBox";
            this.betBox.Size = new System.Drawing.Size(100, 20);
            this.betBox.TabIndex = 1;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(9, 257);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(29, 13);
            this.betLabel.TabIndex = 2;
            this.betLabel.Text = "Bet: ";
            // 
            // gameElement1
            // 
            this.gameElement1.AutoSize = true;
            this.gameElement1.Location = new System.Drawing.Point(6, 61);
            this.gameElement1.Name = "gameElement1";
            this.gameElement1.Size = new System.Drawing.Size(35, 13);
            this.gameElement1.TabIndex = 3;
            this.gameElement1.Text = "label1";
            // 
            // gameElement2
            // 
            this.gameElement2.AutoSize = true;
            this.gameElement2.Location = new System.Drawing.Point(71, 61);
            this.gameElement2.Name = "gameElement2";
            this.gameElement2.Size = new System.Drawing.Size(35, 13);
            this.gameElement2.TabIndex = 4;
            this.gameElement2.Text = "label2";
            // 
            // gameElement3
            // 
            this.gameElement3.AutoSize = true;
            this.gameElement3.Location = new System.Drawing.Point(141, 61);
            this.gameElement3.Name = "gameElement3";
            this.gameElement3.Size = new System.Drawing.Size(35, 13);
            this.gameElement3.TabIndex = 5;
            this.gameElement3.Text = "label3";
            // 
            // gameElement4
            // 
            this.gameElement4.AutoSize = true;
            this.gameElement4.Location = new System.Drawing.Point(211, 61);
            this.gameElement4.Name = "gameElement4";
            this.gameElement4.Size = new System.Drawing.Size(35, 13);
            this.gameElement4.TabIndex = 6;
            this.gameElement4.Text = "label4";
            // 
            // gameElement5
            // 
            this.gameElement5.AutoSize = true;
            this.gameElement5.Location = new System.Drawing.Point(279, 61);
            this.gameElement5.Name = "gameElement5";
            this.gameElement5.Size = new System.Drawing.Size(35, 13);
            this.gameElement5.TabIndex = 7;
            this.gameElement5.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameElement5);
            this.groupBox1.Controls.Add(this.gameElement4);
            this.groupBox1.Controls.Add(this.gameElement3);
            this.groupBox1.Controls.Add(this.gameElement2);
            this.groupBox1.Controls.Add(this.gameElement1);
            this.groupBox1.Location = new System.Drawing.Point(66, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick Game";
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(311, 252);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 23);
            this.commitButton.TabIndex = 9;
            this.commitButton.UseVisualStyleBackColor = true;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(66, 180);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(7, 13);
            this.instructionLabel.TabIndex = 10;
            this.instructionLabel.Text = "\r\n";
            // 
            // pickGameLabel
            // 
            this.pickGameLabel.AutoSize = true;
            this.pickGameLabel.Location = new System.Drawing.Point(12, 295);
            this.pickGameLabel.Name = "pickGameLabel";
            this.pickGameLabel.Size = new System.Drawing.Size(59, 13);
            this.pickGameLabel.TabIndex = 11;
            this.pickGameLabel.Text = "Pick Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 347);
            this.Controls.Add(this.pickGameLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.betBox);
            this.Controls.Add(this.gamePicker);
            this.Name = "Form1";
            this.Text = "Gambling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gamePicker;
        private System.Windows.Forms.TextBox betBox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label gameElement1;
        private System.Windows.Forms.Label gameElement2;
        private System.Windows.Forms.Label gameElement3;
        private System.Windows.Forms.Label gameElement4;
        private System.Windows.Forms.Label gameElement5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Label pickGameLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}


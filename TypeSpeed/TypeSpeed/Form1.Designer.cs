namespace TypeSpeed
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
            this.components = new System.ComponentModel.Container();
            this.TimerSpeed = new System.Windows.Forms.Timer(this.components);
            this.ChatacterTextbox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CorrectLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MissLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.CorrectValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MissValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccuracyValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DifficutyValueLabel = new System.Windows.Forms.ToolStripProgressBar();
            this.DifficutyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerSpeed
            // 
            this.TimerSpeed.Enabled = true;
            this.TimerSpeed.Interval = 1000;
            this.TimerSpeed.Tick += new System.EventHandler(this.TimerSpeed_Tick);
            // 
            // ChatacterTextbox
            // 
            this.ChatacterTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChatacterTextbox.Enabled = false;
            this.ChatacterTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatacterTextbox.ForeColor = System.Drawing.Color.Blue;
            this.ChatacterTextbox.Location = new System.Drawing.Point(12, 12);
            this.ChatacterTextbox.Name = "ChatacterTextbox";
            this.ChatacterTextbox.ReadOnly = true;
            this.ChatacterTextbox.Size = new System.Drawing.Size(1061, 98);
            this.ChatacterTextbox.TabIndex = 0;
            this.ChatacterTextbox.TextChanged += new System.EventHandler(this.ChatacterTextbox_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CorrectLabel,
            this.CorrectValueLabel,
            this.MissLabel,
            this.MissValueLabel,
            this.AccuracyLabel,
            this.AccuracyValueLabel,
            this.DifficutyLabel,
            this.DifficutyValueLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 152);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1085, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(60, 20);
            this.CorrectLabel.Text = "Correct:";
            // 
            // MissLabel
            // 
            this.MissLabel.Name = "MissLabel";
            this.MissLabel.Size = new System.Drawing.Size(41, 20);
            this.MissLabel.Text = "Miss:";
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(71, 20);
            this.AccuracyLabel.Text = "Accuracy:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 32);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(983, 121);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(90, 20);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "Game over!";
            this.gameOverLabel.Visible = false;
            // 
            // CorrectValueLabel
            // 
            this.CorrectValueLabel.Name = "CorrectValueLabel";
            this.CorrectValueLabel.Size = new System.Drawing.Size(17, 20);
            this.CorrectValueLabel.Text = "0";
            // 
            // MissValueLabel
            // 
            this.MissValueLabel.Name = "MissValueLabel";
            this.MissValueLabel.Size = new System.Drawing.Size(17, 20);
            this.MissValueLabel.Text = "0";
            // 
            // AccuracyValueLabel
            // 
            this.AccuracyValueLabel.Name = "AccuracyValueLabel";
            this.AccuracyValueLabel.Size = new System.Drawing.Size(29, 20);
            this.AccuracyValueLabel.Text = "0%";
            // 
            // DifficutyValueLabel
            // 
            this.DifficutyValueLabel.Name = "DifficutyValueLabel";
            this.DifficutyValueLabel.Size = new System.Drawing.Size(100, 18);
            // 
            // DifficutyLabel
            // 
            this.DifficutyLabel.Name = "DifficutyLabel";
            this.DifficutyLabel.Size = new System.Drawing.Size(65, 20);
            this.DifficutyLabel.Text = "Difficuty";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(114, 124);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 17);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(164, 124);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(16, 17);
            this.TotalValueLabel.TabIndex = 7;
            this.TotalValueLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 178);
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ChatacterTextbox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Type Speed";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerSpeed;
        private System.Windows.Forms.TextBox ChatacterTextbox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CorrectLabel;
        private System.Windows.Forms.ToolStripStatusLabel MissLabel;
        private System.Windows.Forms.ToolStripStatusLabel AccuracyLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.ToolStripStatusLabel CorrectValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel MissValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel AccuracyValueLabel;
        private System.Windows.Forms.ToolStripProgressBar DifficutyValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel DifficutyLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalValueLabel;
    }
}



namespace DigitalPokerChips
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
            this.homePanel = new System.Windows.Forms.Panel();
            this.transaktionButton = new System.Windows.Forms.Button();
            this.buchungButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.homePanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.transaktionButton);
            this.homePanel.Controls.Add(this.buchungButton);
            this.homePanel.Controls.Add(this.startButton);
            this.homePanel.Controls.Add(this.userPanel);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(155, 450);
            this.homePanel.TabIndex = 0;
            // 
            // transaktionButton
            // 
            this.transaktionButton.FlatAppearance.BorderSize = 0;
            this.transaktionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaktionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transaktionButton.Location = new System.Drawing.Point(0, 175);
            this.transaktionButton.Margin = new System.Windows.Forms.Padding(0);
            this.transaktionButton.Name = "transaktionButton";
            this.transaktionButton.Size = new System.Drawing.Size(155, 50);
            this.transaktionButton.TabIndex = 3;
            this.transaktionButton.Text = "Transaktionen";
            this.transaktionButton.UseVisualStyleBackColor = true;
            // 
            // buchungButton
            // 
            this.buchungButton.FlatAppearance.BorderSize = 0;
            this.buchungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buchungButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buchungButton.Location = new System.Drawing.Point(0, 125);
            this.buchungButton.Margin = new System.Windows.Forms.Padding(0);
            this.buchungButton.Name = "buchungButton";
            this.buchungButton.Size = new System.Drawing.Size(155, 50);
            this.buchungButton.TabIndex = 2;
            this.buchungButton.Text = "Buchung";
            this.buchungButton.UseVisualStyleBackColor = true;
            this.buchungButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(0, 75);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(155, 50);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Startseite / Anmeldung";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPanel.Controls.Add(this.label2);
            this.userPanel.Controls.Add(this.label1);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(155, 75);
            this.userPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "947620";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.panel2);
            this.startPanel.Controls.Add(this.panel1);
            this.startPanel.Controls.Add(this.label3);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(155, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(645, 450);
            this.startPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "StartPanel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(407, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(407, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "BuchungsPanel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "TransaktionenPanel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.homePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.homePanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button buchungButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button transaktionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}


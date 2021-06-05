
namespace DigitalPokerChips
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ausleseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chipIdBox = new System.Windows.Forms.TextBox();
            this.standLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Label();
            this.registrierButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uidTextbox = new System.Windows.Forms.TextBox();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.betragTextbox = new System.Windows.Forms.TextBox();
            this.abbuchButton = new System.Windows.Forms.Button();
            this.aufbuchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1062, 443);
            this.mainPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.ausleseButton);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.chipIdBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(10, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 216);
            this.panel4.TabIndex = 10;
            // 
            // ausleseButton
            // 
            this.ausleseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ausleseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ausleseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.ausleseButton.Location = new System.Drawing.Point(185, 70);
            this.ausleseButton.Name = "ausleseButton";
            this.ausleseButton.Size = new System.Drawing.Size(75, 24);
            this.ausleseButton.TabIndex = 8;
            this.ausleseButton.Text = "Auslesen";
            this.ausleseButton.UseVisualStyleBackColor = false;
            this.ausleseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(21, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Halte deine Karte an den Scanner";
            // 
            // chipIdBox
            // 
            this.chipIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.chipIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chipIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.chipIdBox.Location = new System.Drawing.Point(25, 70);
            this.chipIdBox.Name = "chipIdBox";
            this.chipIdBox.Size = new System.Drawing.Size(130, 24);
            this.chipIdBox.TabIndex = 6;
            // 
            // standLable
            // 
            this.standLable.AutoSize = true;
            this.standLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.standLable.Location = new System.Drawing.Point(3, 0);
            this.standLable.Name = "standLable";
            this.standLable.Size = new System.Drawing.Size(182, 20);
            this.standLable.TabIndex = 1;
            this.standLable.Text = "Du hast aktuell --- Chips!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ScanPanel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.registerPanel);
            this.panel3.Controls.Add(this.registrierButton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.uidTextbox);
            this.panel3.Controls.Add(this.abbrechenButton);
            this.panel3.Controls.Add(this.nameTextbox);
            this.panel3.Location = new System.Drawing.Point(332, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 239);
            this.panel3.TabIndex = 9;
            // 
            // registerPanel
            // 
            this.registerPanel.AutoSize = true;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(101, 13);
            this.registerPanel.TabIndex = 9;
            this.registerPanel.Text = "RegistrierungsPanel";
            // 
            // registrierButton
            // 
            this.registrierButton.Location = new System.Drawing.Point(118, 142);
            this.registrierButton.Name = "registrierButton";
            this.registrierButton.Size = new System.Drawing.Size(67, 20);
            this.registrierButton.TabIndex = 8;
            this.registrierButton.Text = "Registrieren";
            this.registrierButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Halte deine Karte an den Scanner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gib hier deinen Namen ein";
            // 
            // uidTextbox
            // 
            this.uidTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.uidTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uidTextbox.Location = new System.Drawing.Point(17, 42);
            this.uidTextbox.Name = "uidTextbox";
            this.uidTextbox.Size = new System.Drawing.Size(103, 20);
            this.uidTextbox.TabIndex = 3;
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Location = new System.Drawing.Point(17, 142);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(64, 20);
            this.abbrechenButton.TabIndex = 7;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextbox.Location = new System.Drawing.Point(17, 99);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(205, 20);
            this.nameTextbox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(680, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 415);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(70, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Noch keine vergangenen Buchungen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TransaktionenPanel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.betragTextbox);
            this.panel1.Controls.Add(this.abbuchButton);
            this.panel1.Controls.Add(this.aufbuchButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(328, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 169);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(25, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Geb deinen Betrag ein";
            // 
            // betragTextbox
            // 
            this.betragTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.betragTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betragTextbox.Location = new System.Drawing.Point(25, 54);
            this.betragTextbox.Name = "betragTextbox";
            this.betragTextbox.Size = new System.Drawing.Size(236, 20);
            this.betragTextbox.TabIndex = 3;
            // 
            // abbuchButton
            // 
            this.abbuchButton.BackColor = System.Drawing.Color.Red;
            this.abbuchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abbuchButton.Location = new System.Drawing.Point(24, 92);
            this.abbuchButton.Name = "abbuchButton";
            this.abbuchButton.Size = new System.Drawing.Size(103, 35);
            this.abbuchButton.TabIndex = 2;
            this.abbuchButton.Text = "- Buchen";
            this.abbuchButton.UseVisualStyleBackColor = false;
            // 
            // aufbuchButton
            // 
            this.aufbuchButton.BackColor = System.Drawing.Color.LimeGreen;
            this.aufbuchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aufbuchButton.Location = new System.Drawing.Point(158, 92);
            this.aufbuchButton.Name = "aufbuchButton";
            this.aufbuchButton.Size = new System.Drawing.Size(103, 35);
            this.aufbuchButton.TabIndex = 1;
            this.aufbuchButton.Text = "+ Buchen";
            this.aufbuchButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "BuchungsPanel";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.standLable);
            this.panel5.Location = new System.Drawing.Point(25, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 24);
            this.panel5.TabIndex = 9;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1062, 443);
            this.Controls.Add(this.mainPanel);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registrierButton;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox uidTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox betragTextbox;
        private System.Windows.Forms.Button abbuchButton;
        private System.Windows.Forms.Button aufbuchButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label registerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox chipIdBox;
        private System.Windows.Forms.Label standLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ausleseButton;
        private System.Windows.Forms.Panel panel5;
    }
}


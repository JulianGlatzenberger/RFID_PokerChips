
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.standLable = new System.Windows.Forms.Label();
            this.ausleseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chipIdBox = new System.Windows.Forms.TextBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.standLable);
            this.panel4.Controls.Add(this.ausleseButton);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.chipIdBox);
            this.panel4.Controls.Add(this.label2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // standLable
            // 
            resources.ApplyResources(this.standLable, "standLable");
            this.standLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.standLable.Name = "standLable";
            // 
            // ausleseButton
            // 
            this.ausleseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.ausleseButton, "ausleseButton");
            this.ausleseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.ausleseButton.Name = "ausleseButton";
            this.ausleseButton.UseVisualStyleBackColor = false;
            this.ausleseButton.Click += new System.EventHandler(this.ausleseButton_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label9.Name = "label9";
            // 
            // chipIdBox
            // 
            this.chipIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.chipIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.chipIdBox, "chipIdBox");
            this.chipIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.chipIdBox.Name = "chipIdBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.registerPanel);
            this.panel3.Controls.Add(this.registrierButton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.uidTextbox);
            this.panel3.Controls.Add(this.abbrechenButton);
            this.panel3.Controls.Add(this.nameTextbox);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // registerPanel
            // 
            resources.ApplyResources(this.registerPanel, "registerPanel");
            this.registerPanel.Name = "registerPanel";
            // 
            // registrierButton
            // 
            resources.ApplyResources(this.registrierButton, "registrierButton");
            this.registrierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.registrierButton.Name = "registrierButton";
            this.registrierButton.UseVisualStyleBackColor = true;
            this.registrierButton.Click += new System.EventHandler(this.registrierButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label7.Name = "label7";
            // 
            // uidTextbox
            // 
            this.uidTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.uidTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.uidTextbox, "uidTextbox");
            this.uidTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.uidTextbox.Name = "uidTextbox";
            // 
            // abbrechenButton
            // 
            resources.ApplyResources(this.abbrechenButton, "abbrechenButton");
            this.abbrechenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.nameTextbox, "nameTextbox");
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.nameTextbox.Name = "nameTextbox";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.betragTextbox);
            this.panel1.Controls.Add(this.abbuchButton);
            this.panel1.Controls.Add(this.aufbuchButton);
            this.panel1.Controls.Add(this.label4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label8.Name = "label8";
            // 
            // betragTextbox
            // 
            this.betragTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.betragTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.betragTextbox, "betragTextbox");
            this.betragTextbox.Name = "betragTextbox";
            this.betragTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.betragTextbox_KeyPress);
            // 
            // abbuchButton
            // 
            this.abbuchButton.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.abbuchButton, "abbuchButton");
            this.abbuchButton.Name = "abbuchButton";
            this.abbuchButton.UseVisualStyleBackColor = false;
            this.abbuchButton.Click += new System.EventHandler(this.abbuchButton_Click);
            // 
            // aufbuchButton
            // 
            this.aufbuchButton.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.aufbuchButton, "aufbuchButton");
            this.aufbuchButton.Name = "aufbuchButton";
            this.aufbuchButton.UseVisualStyleBackColor = false;
            this.aufbuchButton.Click += new System.EventHandler(this.aufbuchButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // mainWindow
            // 
            this.AcceptButton = this.ausleseButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
    }
}


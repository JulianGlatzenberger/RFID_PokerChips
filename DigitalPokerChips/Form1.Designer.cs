
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.standLable = new System.Windows.Forms.Label();
            this.ausleseButton = new System.Windows.Forms.Button();
            this.chipIdBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Transaktionsnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChipID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Buchungsbetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Startanzahl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uhrzeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.betragTextbox = new System.Windows.Forms.TextBox();
            this.abbuchButton = new System.Windows.Forms.Button();
            this.aufbuchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.abbrechenButton);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.nameLabel);
            this.panel4.Controls.Add(this.standLable);
            this.panel4.Controls.Add(this.ausleseButton);
            this.panel4.Controls.Add(this.chipIdBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Name = "panel4";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.nameLabel.Name = "nameLabel";
            // 
            // standLable
            // 
            resources.ApplyResources(this.standLable, "standLable");
            this.standLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.standLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.standLable.Name = "standLable";
            // 
            // ausleseButton
            // 
            resources.ApplyResources(this.ausleseButton, "ausleseButton");
            this.ausleseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ausleseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.ausleseButton.Name = "ausleseButton";
            this.ausleseButton.UseVisualStyleBackColor = false;
            this.ausleseButton.Click += new System.EventHandler(this.ausleseButton_Click);
            // 
            // chipIdBox
            // 
            resources.ApplyResources(this.chipIdBox, "chipIdBox");
            this.chipIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.chipIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chipIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.chipIdBox.Name = "chipIdBox";
            this.chipIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chipIdBox_KeyPress);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label9.Name = "label9";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Name = "panel2";
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Transaktionsnummer,
            this.ChipID,
            this.Buchungsbetrag,
            this.Startanzahl,
            this.Uhrzeit});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Transaktionsnummer
            // 
            resources.ApplyResources(this.Transaktionsnummer, "Transaktionsnummer");
            // 
            // ChipID
            // 
            resources.ApplyResources(this.ChipID, "ChipID");
            // 
            // Buchungsbetrag
            // 
            resources.ApplyResources(this.Buchungsbetrag, "Buchungsbetrag");
            // 
            // Startanzahl
            // 
            resources.ApplyResources(this.Startanzahl, "Startanzahl");
            // 
            // Uhrzeit
            // 
            resources.ApplyResources(this.Uhrzeit, "Uhrzeit");
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.betragTextbox);
            this.panel1.Controls.Add(this.abbuchButton);
            this.panel1.Controls.Add(this.aufbuchButton);
            this.panel1.Controls.Add(this.label4);
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
            this.betragTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
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
            // abbrechenButton
            // 
            this.abbrechenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.abbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.abbrechenButton, "abbrechenButton");
            this.abbrechenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.UseVisualStyleBackColor = false;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // mainWindow
            // 
            this.AcceptButton = this.ausleseButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CancelButton = this.abbrechenButton;
            this.Controls.Add(this.mainPanel);
            this.Name = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox betragTextbox;
        private System.Windows.Forms.Button abbuchButton;
        private System.Windows.Forms.Button aufbuchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox chipIdBox;
        private System.Windows.Forms.Label standLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ausleseButton;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Transaktionsnummer;
        private System.Windows.Forms.ColumnHeader ChipID;
        private System.Windows.Forms.ColumnHeader Uhrzeit;
        private System.Windows.Forms.ColumnHeader Startanzahl;
        private System.Windows.Forms.ColumnHeader Buchungsbetrag;
        private System.Windows.Forms.Label nameLabel;
    }
}


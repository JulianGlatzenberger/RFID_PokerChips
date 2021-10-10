
namespace DigitalPokerChips_Registrierfenster
{
    partial class Registerwindow
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
            this.registrierButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uidTextbox = new System.Windows.Forms.TextBox();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrierButton
            // 
            this.registrierButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.registrierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.registrierButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registrierButton.Location = new System.Drawing.Point(191, 3);
            this.registrierButton.Name = "registrierButton";
            this.registrierButton.Size = new System.Drawing.Size(122, 29);
            this.registrierButton.TabIndex = 8;
            this.registrierButton.Text = "Registrieren";
            this.registrierButton.UseVisualStyleBackColor = true;
            this.registrierButton.Click += new System.EventHandler(this.RegistrierButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Halte deine Karte an den Scanner";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gib hier deinen Namen ein";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uidTextbox
            // 
            this.uidTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uidTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.uidTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.uidTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.uidTextbox.Location = new System.Drawing.Point(111, 55);
            this.uidTextbox.MaxLength = 10;
            this.uidTextbox.Name = "uidTextbox";
            this.uidTextbox.Size = new System.Drawing.Size(139, 24);
            this.uidTextbox.TabIndex = 3;
            this.uidTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uidTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UidTextbox_KeyPress);
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.abbrechenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbrechenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abbrechenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.abbrechenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.abbrechenButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.abbrechenButton.Location = new System.Drawing.Point(42, 3);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(113, 29);
            this.abbrechenButton.TabIndex = 7;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.AbbrechenButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.nameTextbox.Location = new System.Drawing.Point(45, 154);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(271, 24);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextbox_KeyPress);
            // 
            // registerPanel
            // 
            this.registerPanel.AutoSize = true;
            this.registerPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerPanel.Location = new System.Drawing.Point(3, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(101, 13);
            this.registerPanel.TabIndex = 9;
            this.registerPanel.Text = "RegistrierungsPanel";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.registerPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.uidTextbox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.20794F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.12873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.13869F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 281);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.90282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.09718F));
            this.tableLayoutPanel2.Controls.Add(this.registrierButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.abbrechenButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 64);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MinimumSize = new System.Drawing.Size(367, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 287);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CancelButton = this.abbrechenButton;
            this.ClientSize = new System.Drawing.Size(391, 312);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "DigitalPokerChips Registrierfenster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label registerPanel;
        private System.Windows.Forms.Button registrierButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uidTextbox;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}


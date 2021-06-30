
namespace DigitalPokerChips_Registrierfenster
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Label();
            this.registrierButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uidTextbox = new System.Windows.Forms.TextBox();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 286);
            this.panel3.TabIndex = 10;
            // 
            // registerPanel
            // 
            this.registerPanel.AutoSize = true;
            this.registerPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerPanel.Location = new System.Drawing.Point(2, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(101, 13);
            this.registerPanel.TabIndex = 9;
            this.registerPanel.Text = "RegistrierungsPanel";
            // 
            // registrierButton
            // 
            this.registrierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.registrierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.registrierButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registrierButton.Location = new System.Drawing.Point(189, 206);
            this.registrierButton.Name = "registrierButton";
            this.registrierButton.Size = new System.Drawing.Size(102, 24);
            this.registrierButton.TabIndex = 8;
            this.registrierButton.Text = "Registrieren";
            this.registrierButton.UseVisualStyleBackColor = true;
            this.registrierButton.Click += new System.EventHandler(this.registrierButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(56, 27);
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
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(70, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gib hier deinen Namen ein";
            // 
            // uidTextbox
            // 
            this.uidTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.uidTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.uidTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.uidTextbox.Location = new System.Drawing.Point(117, 62);
            this.uidTextbox.MaxLength = 10;
            this.uidTextbox.Name = "uidTextbox";
            this.uidTextbox.Size = new System.Drawing.Size(103, 24);
            this.uidTextbox.TabIndex = 3;
            this.uidTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uidTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uidTextbox_KeyPress);
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbrechenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abbrechenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.abbrechenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.abbrechenButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.abbrechenButton.Location = new System.Drawing.Point(51, 206);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(84, 24);
            this.abbrechenButton.TabIndex = 7;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(221)))), ((int)(((byte)(218)))));
            this.nameTextbox.Location = new System.Drawing.Point(51, 150);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(240, 24);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextbox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CancelButton = this.abbrechenButton;
            this.ClientSize = new System.Drawing.Size(392, 310);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "DigitalPokerChips Registrierfenster";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label registerPanel;
        private System.Windows.Forms.Button registrierButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uidTextbox;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}


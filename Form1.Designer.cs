
namespace PasswordGenerator
{
    partial class mainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.generateBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.mainHeader = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxSymbol = new System.Windows.Forms.CheckBox();
            this.checkboxNumber = new System.Windows.Forms.CheckBox();
            this.lengthedit = new System.Windows.Forms.NumericUpDown();
            this.errorMsgLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.moreButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthedit)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBTN
            // 
            this.generateBTN.Location = new System.Drawing.Point(102, 229);
            this.generateBTN.Name = "generateBTN";
            this.generateBTN.Size = new System.Drawing.Size(75, 23);
            this.generateBTN.TabIndex = 0;
            this.generateBTN.Text = "Generate";
            this.generateBTN.UseVisualStyleBackColor = true;
            this.generateBTN.Click += new System.EventHandler(this.generateBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(183, 229);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // mainHeader
            // 
            this.mainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHeader.AutoSize = true;
            this.mainHeader.Font = new System.Drawing.Font("Ethnocentric", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeader.ForeColor = System.Drawing.SystemColors.Info;
            this.mainHeader.Location = new System.Drawing.Point(3, 0);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(372, 20);
            this.mainHeader.TabIndex = 2;
            this.mainHeader.Text = "Password Generator";
            this.mainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoText
            // 
            this.infoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoText.AutoSize = true;
            this.infoText.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoText.Location = new System.Drawing.Point(3, 20);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(372, 13);
            this.infoText.TabIndex = 3;
            this.infoText.Text = "Welcome to Password Gernerator v0.1";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoText.Click += new System.EventHandler(this.infoText_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.AutoSize = true;
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headerPanel.Controls.Add(this.mainHeader);
            this.headerPanel.Controls.Add(this.infoText);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.headerPanel.Location = new System.Drawing.Point(21, 14);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(382, 54);
            this.headerPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Software Development and Design © 2022 S3R43o3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(58, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gebe eine Passwortlänge ein";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkboxSymbol
            // 
            this.checkboxSymbol.AutoSize = true;
            this.checkboxSymbol.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkboxSymbol.Location = new System.Drawing.Point(111, 168);
            this.checkboxSymbol.Name = "checkboxSymbol";
            this.checkboxSymbol.Size = new System.Drawing.Size(66, 17);
            this.checkboxSymbol.TabIndex = 8;
            this.checkboxSymbol.Text = "Symbole";
            this.checkboxSymbol.UseVisualStyleBackColor = true;
            this.checkboxSymbol.CheckedChanged += new System.EventHandler(this.checkboxSymbol_CheckedChanged);
            // 
            // checkboxNumber
            // 
            this.checkboxNumber.AutoSize = true;
            this.checkboxNumber.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkboxNumber.Location = new System.Drawing.Point(259, 168);
            this.checkboxNumber.Name = "checkboxNumber";
            this.checkboxNumber.Size = new System.Drawing.Size(59, 17);
            this.checkboxNumber.TabIndex = 9;
            this.checkboxNumber.Text = "Zahlen";
            this.checkboxNumber.UseVisualStyleBackColor = true;
            this.checkboxNumber.CheckedChanged += new System.EventHandler(this.checkboxNumber_CheckedChanged);
            // 
            // lengthedit
            // 
            this.lengthedit.Location = new System.Drawing.Point(285, 121);
            this.lengthedit.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.lengthedit.Name = "lengthedit";
            this.lengthedit.Size = new System.Drawing.Size(49, 20);
            this.lengthedit.TabIndex = 10;
            this.lengthedit.ValueChanged += new System.EventHandler(this.lengthedit_ValueChanged);
            // 
            // errorMsgLabel
            // 
            this.errorMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMsgLabel.Location = new System.Drawing.Point(21, 94);
            this.errorMsgLabel.Name = "errorMsgLabel";
            this.errorMsgLabel.Size = new System.Drawing.Size(382, 23);
            this.errorMsgLabel.TabIndex = 11;
            this.errorMsgLabel.Text = "Error Messages";
            this.errorMsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sollen Zahlen und/oder Symbole verwendet werden?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordText.Location = new System.Drawing.Point(26, 191);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(375, 15);
            this.passwordText.TabIndex = 13;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Your new Password here";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moreButton
            // 
            this.moreButton.Location = new System.Drawing.Point(264, 229);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 23);
            this.moreButton.TabIndex = 14;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // mainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(423, 278);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorMsgLabel);
            this.Controls.Add(this.lengthedit);
            this.Controls.Add(this.checkboxNumber);
            this.Controls.Add(this.checkboxSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.generateBTN);
            this.Controls.Add(this.exitBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password Generator v0.1";
            this.Load += new System.EventHandler(this.mainUI_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label mainHeader;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxSymbol;
        private System.Windows.Forms.CheckBox checkboxNumber;
        private System.Windows.Forms.NumericUpDown lengthedit;
        private System.Windows.Forms.Label errorMsgLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button moreButton;
    }
}


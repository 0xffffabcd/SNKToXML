namespace SNKToXML
{
    partial class MainForm
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
            this.OpenSNKFileButton = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.savePublicKeyButton = new System.Windows.Forms.Button();
            this.savePrivateKeyButton = new System.Windows.Forms.Button();
            this.ShowAboutBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSNKFileButton
            // 
            this.OpenSNKFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSNKFileButton.Location = new System.Drawing.Point(327, 25);
            this.OpenSNKFileButton.Name = "OpenSNKFileButton";
            this.OpenSNKFileButton.Size = new System.Drawing.Size(113, 23);
            this.OpenSNKFileButton.TabIndex = 0;
            this.OpenSNKFileButton.Text = "Open SNK File";
            this.OpenSNKFileButton.UseVisualStyleBackColor = true;
            this.OpenSNKFileButton.Click += new System.EventHandler(this.OpenSNKFileButtonClick);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(12, 25);
            this.publicKeyTextBox.Multiline = true;
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publicKeyTextBox.Size = new System.Drawing.Size(309, 98);
            this.publicKeyTextBox.TabIndex = 1;
            this.publicKeyTextBox.WordWrap = false;
            this.publicKeyTextBox.TextChanged += new System.EventHandler(this.PublicKeyTextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private/Public Key";
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateKeyTextBox.Location = new System.Drawing.Point(15, 142);
            this.privateKeyTextBox.Multiline = true;
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.ReadOnly = true;
            this.privateKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privateKeyTextBox.Size = new System.Drawing.Size(306, 155);
            this.privateKeyTextBox.TabIndex = 4;
            this.privateKeyTextBox.WordWrap = false;
            this.privateKeyTextBox.TextChanged += new System.EventHandler(this.PrivateKeyTextBoxTextChanged);
            // 
            // savePublicKeyButton
            // 
            this.savePublicKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePublicKeyButton.Enabled = false;
            this.savePublicKeyButton.Location = new System.Drawing.Point(327, 54);
            this.savePublicKeyButton.Name = "savePublicKeyButton";
            this.savePublicKeyButton.Size = new System.Drawing.Size(113, 23);
            this.savePublicKeyButton.TabIndex = 5;
            this.savePublicKeyButton.Text = "Save Public Key";
            this.savePublicKeyButton.UseVisualStyleBackColor = true;
            this.savePublicKeyButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // savePrivateKeyButton
            // 
            this.savePrivateKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePrivateKeyButton.Enabled = false;
            this.savePrivateKeyButton.Location = new System.Drawing.Point(327, 83);
            this.savePrivateKeyButton.Name = "savePrivateKeyButton";
            this.savePrivateKeyButton.Size = new System.Drawing.Size(113, 23);
            this.savePrivateKeyButton.TabIndex = 6;
            this.savePrivateKeyButton.Text = "Save Private Key";
            this.savePrivateKeyButton.UseVisualStyleBackColor = true;
            this.savePrivateKeyButton.Click += new System.EventHandler(this.Button2Click);
            // 
            // ShowAboutBoxButton
            // 
            this.ShowAboutBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAboutBoxButton.Location = new System.Drawing.Point(327, 275);
            this.ShowAboutBoxButton.Name = "ShowAboutBoxButton";
            this.ShowAboutBoxButton.Size = new System.Drawing.Size(113, 23);
            this.ShowAboutBoxButton.TabIndex = 7;
            this.ShowAboutBoxButton.Text = "About";
            this.ShowAboutBoxButton.UseVisualStyleBackColor = true;
            this.ShowAboutBoxButton.Click += new System.EventHandler(this.ShowAboutBoxButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 310);
            this.Controls.Add(this.ShowAboutBoxButton);
            this.Controls.Add(this.savePrivateKeyButton);
            this.Controls.Add(this.savePublicKeyButton);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.OpenSNKFileButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 340);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNK to XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenSNKFileButton;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Button savePublicKeyButton;
        private System.Windows.Forms.Button savePrivateKeyButton;
        private System.Windows.Forms.Button ShowAboutBoxButton;
    }
}


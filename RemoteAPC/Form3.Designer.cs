namespace RemoteAPC
{
    partial class Form3
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
            this.userLabel = new System.Windows.Forms.Label();
            this.appPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.filedialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.installButton = new System.Windows.Forms.Button();
            this.appPathLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lboxSoftware = new System.Windows.Forms.Label();
            this.tboxSoftwarePath = new System.Windows.Forms.TextBox();
            this.fdbRemotePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(279, 19);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "username";
            // 
            // appPathTextBox
            // 
            this.appPathTextBox.Location = new System.Drawing.Point(141, 84);
            this.appPathTextBox.Name = "appPathTextBox";
            this.appPathTextBox.Size = new System.Drawing.Size(342, 20);
            this.appPathTextBox.TabIndex = 2;
            this.appPathTextBox.TextChanged += new System.EventHandler(this.appPathTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "account software is to be installed";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(179, 301);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 6;
            // 
            // filedialogueBox
            // 
            this.filedialogueBox.Filter = "MSI|*.msi";
            // 
            // installButton
            // 
            this.installButton.Enabled = false;
            this.installButton.Location = new System.Drawing.Point(182, 208);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 8;
            this.installButton.Text = "install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // appPathLabel
            // 
            this.appPathLabel.AutoSize = true;
            this.appPathLabel.Location = new System.Drawing.Point(50, 88);
            this.appPathLabel.Name = "appPathLabel";
            this.appPathLabel.Size = new System.Drawing.Size(72, 13);
            this.appPathLabel.TabIndex = 9;
            this.appPathLabel.Text = "Remote Path:";
            this.appPathLabel.Click += new System.EventHandler(this.appPathLabel_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(141, 118);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.userNameTextBox.TabIndex = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(65, 118);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(53, 13);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(141, 144);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(161, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(65, 151);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "password";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(490, 83);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(491, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lboxSoftware
            // 
            this.lboxSoftware.AutoSize = true;
            this.lboxSoftware.Location = new System.Drawing.Point(42, 57);
            this.lboxSoftware.Name = "lboxSoftware";
            this.lboxSoftware.Size = new System.Drawing.Size(80, 13);
            this.lboxSoftware.TabIndex = 16;
            this.lboxSoftware.Text = "Software Path: ";
            // 
            // tboxSoftwarePath
            // 
            this.tboxSoftwarePath.Location = new System.Drawing.Point(142, 53);
            this.tboxSoftwarePath.Name = "tboxSoftwarePath";
            this.tboxSoftwarePath.Size = new System.Drawing.Size(342, 20);
            this.tboxSoftwarePath.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxSoftware);
            this.Controls.Add(this.tboxSoftwarePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.appPathLabel);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appPathTextBox);
            this.Controls.Add(this.userLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox appPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog filedialogueBox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label appPathLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lboxSoftware;
        private System.Windows.Forms.TextBox tboxSoftwarePath;
        private System.Windows.Forms.FolderBrowserDialog fdbRemotePath;
    }
}
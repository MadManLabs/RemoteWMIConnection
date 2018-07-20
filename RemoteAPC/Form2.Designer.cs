namespace RemoteAPC
{
    partial class Form2
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.ListBox();
            this.pcNameLabel = new System.Windows.Forms.Label();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.installLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.Location = new System.Drawing.Point(135, 28);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(167, 20);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Installed Applications  ";
            // 
            // view
            // 
            this.view.FormattingEnabled = true;
            this.view.Location = new System.Drawing.Point(22, 86);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(377, 173);
            this.view.TabIndex = 1;
            // 
            // pcNameLabel
            // 
            this.pcNameLabel.AutoSize = true;
            this.pcNameLabel.Location = new System.Drawing.Point(189, 59);
            this.pcNameLabel.Name = "pcNameLabel";
            this.pcNameLabel.Size = new System.Drawing.Size(35, 13);
            this.pcNameLabel.TabIndex = 2;
            this.pcNameLabel.Text = "label1";
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(149, 282);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(75, 23);
            this.uninstallBtn.TabIndex = 3;
            this.uninstallBtn.Text = "uninstall";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.uninstallBtn_Click);
            // 
            // installLabel
            // 
            this.installLabel.AutoSize = true;
            this.installLabel.Location = new System.Drawing.Point(289, 287);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(35, 13);
            this.installLabel.TabIndex = 4;
            this.installLabel.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 317);
            this.Controls.Add(this.installLabel);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.pcNameLabel);
            this.Controls.Add(this.view);
            this.Controls.Add(this.errorLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.ListBox view;
        public System.Windows.Forms.Label pcNameLabel;
        private System.Windows.Forms.Button uninstallBtn;
        private System.Windows.Forms.Label installLabel;
    }
}
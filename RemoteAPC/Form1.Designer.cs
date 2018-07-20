namespace RemoteAPC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcListComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataDisplayColomn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WMIClassComboBox = new System.Windows.Forms.ComboBox();
            this.WMIClassLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC\'s on the network";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcListComboBox
            // 
            this.pcListComboBox.FormattingEnabled = true;
            this.pcListComboBox.Location = new System.Drawing.Point(41, 63);
            this.pcListComboBox.Name = "pcListComboBox";
            this.pcListComboBox.Size = new System.Drawing.Size(119, 21);
            this.pcListComboBox.TabIndex = 1;
            this.pcListComboBox.SelectedIndexChanged += new System.EventHandler(this.pcListComboBox_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(321, 63);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.DataDisplayColomn});
            this.listView.Location = new System.Drawing.Point(41, 92);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(355, 196);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 150;
            // 
            // DataDisplayColomn
            // 
            this.DataDisplayColomn.Text = "";
            this.DataDisplayColomn.Width = 200;
            // 
            // WMIClassComboBox
            // 
            this.WMIClassComboBox.FormattingEnabled = true;
            this.WMIClassComboBox.Location = new System.Drawing.Point(184, 63);
            this.WMIClassComboBox.Name = "WMIClassComboBox";
            this.WMIClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.WMIClassComboBox.TabIndex = 4;
            this.WMIClassComboBox.SelectedIndexChanged += new System.EventHandler(this.WMIClassComboBox_SelectedIndexChanged);
            // 
            // WMIClassLabel
            // 
            this.WMIClassLabel.AutoSize = true;
            this.WMIClassLabel.Location = new System.Drawing.Point(213, 36);
            this.WMIClassLabel.Name = "WMIClassLabel";
            this.WMIClassLabel.Size = new System.Drawing.Size(58, 13);
            this.WMIClassLabel.TabIndex = 5;
            this.WMIClassLabel.Text = "WMI Class";
            this.WMIClassLabel.Click += new System.EventHandler(this.WMIClassLabel_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(357, 18);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 6;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(156, 9);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(35, 13);
            this.errorMessage.TabIndex = 7;
            this.errorMessage.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 333);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.WMIClassLabel);
            this.Controls.Add(this.WMIClassComboBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.pcListComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pcListComboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox WMIClassComboBox;
        private System.Windows.Forms.Label WMIClassLabel;
        private System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader DataDisplayColomn;
        private System.Windows.Forms.Label errorMessage;
    }
}


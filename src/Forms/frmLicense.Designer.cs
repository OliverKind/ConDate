﻿namespace OLKI.Programme.ReFiDa
{
    partial class License
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
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboLicenseName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(12, 39);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLicense.Size = new System.Drawing.Size(380, 397);
            this.txtLicense.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(380, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboLicenseName
            // 
            this.cboLicenseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicenseName.FormattingEnabled = true;
            this.cboLicenseName.Items.AddRange(new object[] {
            "CC4.0-License",
            "LGPL-License"});
            this.cboLicenseName.Location = new System.Drawing.Point(12, 12);
            this.cboLicenseName.Name = "cboLicenseName";
            this.cboLicenseName.Size = new System.Drawing.Size(380, 21);
            this.cboLicenseName.TabIndex = 0;
            this.cboLicenseName.SelectedIndexChanged += new System.EventHandler(this.cboLicenseName_SelectedIndexChanged);
            // 
            // License
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(404, 477);
            this.Controls.Add(this.cboLicenseName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtLicense);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "License";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lizenz";
            this.Shown += new System.EventHandler(this.License_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboLicenseName;
    }
}
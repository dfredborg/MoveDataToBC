namespace WinOdataBc
{
    partial class SetupWebService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWebService));
            this.label5 = new System.Windows.Forms.Label();
            this.cbxWebServiceDirect = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxWebServiceFunctions = new System.Windows.Forms.ComboBox();
            this.tbxWebServicePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxWebServiceUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxWebServiceUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Direct Create:";
            // 
            // cbxWebServiceDirect
            // 
            this.cbxWebServiceDirect.AutoSize = true;
            this.cbxWebServiceDirect.Location = new System.Drawing.Point(143, 111);
            this.cbxWebServiceDirect.Name = "cbxWebServiceDirect";
            this.cbxWebServiceDirect.Size = new System.Drawing.Size(15, 14);
            this.cbxWebServiceDirect.TabIndex = 32;
            this.cbxWebServiceDirect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Web Service Function:";
            // 
            // cbxWebServiceFunctions
            // 
            this.cbxWebServiceFunctions.FormattingEnabled = true;
            this.cbxWebServiceFunctions.Location = new System.Drawing.Point(143, 83);
            this.cbxWebServiceFunctions.Name = "cbxWebServiceFunctions";
            this.cbxWebServiceFunctions.Size = new System.Drawing.Size(148, 21);
            this.cbxWebServiceFunctions.TabIndex = 30;
            this.cbxWebServiceFunctions.DropDown += new System.EventHandler(this.cbxWebServiceFunctions_DropDown);
            // 
            // tbxWebServicePassword
            // 
            this.tbxWebServicePassword.Location = new System.Drawing.Point(143, 57);
            this.tbxWebServicePassword.Name = "tbxWebServicePassword";
            this.tbxWebServicePassword.Size = new System.Drawing.Size(297, 20);
            this.tbxWebServicePassword.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Web Service Password:";
            // 
            // tbxWebServiceUser
            // 
            this.tbxWebServiceUser.Location = new System.Drawing.Point(143, 34);
            this.tbxWebServiceUser.Name = "tbxWebServiceUser";
            this.tbxWebServiceUser.Size = new System.Drawing.Size(163, 20);
            this.tbxWebServiceUser.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Web Service Username:";
            // 
            // tbxWebServiceUrl
            // 
            this.tbxWebServiceUrl.Location = new System.Drawing.Point(143, 7);
            this.tbxWebServiceUrl.Name = "tbxWebServiceUrl";
            this.tbxWebServiceUrl.Size = new System.Drawing.Size(361, 20);
            this.tbxWebServiceUrl.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Web Service URL:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(489, 42);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SetupWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(528, 187);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxWebServiceDirect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxWebServiceFunctions);
            this.Controls.Add(this.tbxWebServicePassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxWebServiceUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxWebServiceUrl);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupWebService";
            this.Text = "Setup Web Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxWebServiceDirect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxWebServiceFunctions;
        private System.Windows.Forms.TextBox tbxWebServicePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxWebServiceUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxWebServiceUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}
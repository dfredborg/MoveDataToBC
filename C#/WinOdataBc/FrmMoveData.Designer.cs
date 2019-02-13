namespace WinOdataBc
{
    partial class FrmMoveData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoveData));
            this.btnChooseDataSource = new System.Windows.Forms.Button();
            this.btnSetupWebService = new System.Windows.Forms.Button();
            this.btnMapping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseDataSource
            // 
            this.btnChooseDataSource.Location = new System.Drawing.Point(12, 12);
            this.btnChooseDataSource.Name = "btnChooseDataSource";
            this.btnChooseDataSource.Size = new System.Drawing.Size(260, 50);
            this.btnChooseDataSource.TabIndex = 24;
            this.btnChooseDataSource.Text = "Choose Data Source";
            this.btnChooseDataSource.UseVisualStyleBackColor = true;
            this.btnChooseDataSource.Click += new System.EventHandler(this.btnChooseDataSource_Click);
            // 
            // btnSetupWebService
            // 
            this.btnSetupWebService.Location = new System.Drawing.Point(12, 73);
            this.btnSetupWebService.Name = "btnSetupWebService";
            this.btnSetupWebService.Size = new System.Drawing.Size(260, 51);
            this.btnSetupWebService.TabIndex = 25;
            this.btnSetupWebService.Text = "Setup Web Service";
            this.btnSetupWebService.UseVisualStyleBackColor = true;
            this.btnSetupWebService.Click += new System.EventHandler(this.btnSetupWebService_Click);
            // 
            // btnMapping
            // 
            this.btnMapping.Location = new System.Drawing.Point(12, 134);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(260, 55);
            this.btnMapping.TabIndex = 26;
            this.btnMapping.Text = "Mapping and Push";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // FrmMoveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(283, 201);
            this.Controls.Add(this.btnMapping);
            this.Controls.Add(this.btnSetupWebService);
            this.Controls.Add(this.btnChooseDataSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMoveData";
            this.Text = "Move Data To BC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseDataSource;
        private System.Windows.Forms.Button btnSetupWebService;
        private System.Windows.Forms.Button btnMapping;
    }
}


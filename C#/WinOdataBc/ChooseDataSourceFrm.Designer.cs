namespace WinOdataBc
{
    partial class ChooseDataSourceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDataSourceFrm));
            this.rbxSQL = new System.Windows.Forms.RadioButton();
            this.rbxExcel = new System.Windows.Forms.RadioButton();
            this.rbxCsv = new System.Windows.Forms.RadioButton();
            this.tbxServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSqlTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxExcelPath = new System.Windows.Forms.TextBox();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseExcel = new System.Windows.Forms.Button();
            this.btnChooseCsv = new System.Windows.Forms.Button();
            this.tbxCsvFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialogCsv = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbxSQL
            // 
            this.rbxSQL.AutoSize = true;
            this.rbxSQL.Location = new System.Drawing.Point(12, 12);
            this.rbxSQL.Name = "rbxSQL";
            this.rbxSQL.Size = new System.Drawing.Size(80, 17);
            this.rbxSQL.TabIndex = 0;
            this.rbxSQL.TabStop = true;
            this.rbxSQL.Text = "SQL Server";
            this.rbxSQL.UseVisualStyleBackColor = true;
            this.rbxSQL.CheckedChanged += new System.EventHandler(this.rbxSQL_CheckedChanged);
            // 
            // rbxExcel
            // 
            this.rbxExcel.AutoSize = true;
            this.rbxExcel.Location = new System.Drawing.Point(108, 12);
            this.rbxExcel.Name = "rbxExcel";
            this.rbxExcel.Size = new System.Drawing.Size(51, 17);
            this.rbxExcel.TabIndex = 1;
            this.rbxExcel.TabStop = true;
            this.rbxExcel.Text = "Excel";
            this.rbxExcel.UseVisualStyleBackColor = true;
            this.rbxExcel.CheckedChanged += new System.EventHandler(this.rbxExcel_CheckedChanged);
            // 
            // rbxCsv
            // 
            this.rbxCsv.AutoSize = true;
            this.rbxCsv.Location = new System.Drawing.Point(178, 12);
            this.rbxCsv.Name = "rbxCsv";
            this.rbxCsv.Size = new System.Drawing.Size(46, 17);
            this.rbxCsv.TabIndex = 2;
            this.rbxCsv.TabStop = true;
            this.rbxCsv.Text = "CSV";
            this.rbxCsv.UseVisualStyleBackColor = true;
            this.rbxCsv.CheckedChanged += new System.EventHandler(this.rbxCsv_CheckedChanged);
            // 
            // tbxServerName
            // 
            this.tbxServerName.Enabled = false;
            this.tbxServerName.Location = new System.Drawing.Point(143, 41);
            this.tbxServerName.Name = "tbxServerName";
            this.tbxServerName.Size = new System.Drawing.Size(146, 20);
            this.tbxServerName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SQL Server name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Database:";
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.Enabled = false;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Location = new System.Drawing.Point(143, 67);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(180, 21);
            this.cbxDatabase.TabIndex = 14;
            this.cbxDatabase.DropDown += new System.EventHandler(this.cbxDatabase_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "From Table name:";
            // 
            // cbxSqlTable
            // 
            this.cbxSqlTable.Enabled = false;
            this.cbxSqlTable.FormattingEnabled = true;
            this.cbxSqlTable.Location = new System.Drawing.Point(143, 94);
            this.cbxSqlTable.Name = "cbxSqlTable";
            this.cbxSqlTable.Size = new System.Drawing.Size(429, 21);
            this.cbxSqlTable.TabIndex = 16;
            this.cbxSqlTable.DropDown += new System.EventHandler(this.cbxSqlTable_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose Excel file:";
            // 
            // tbxExcelPath
            // 
            this.tbxExcelPath.Enabled = false;
            this.tbxExcelPath.Location = new System.Drawing.Point(143, 143);
            this.tbxExcelPath.Name = "tbxExcelPath";
            this.tbxExcelPath.Size = new System.Drawing.Size(429, 20);
            this.tbxExcelPath.TabIndex = 18;
            // 
            // btnChooseExcel
            // 
            this.btnChooseExcel.Location = new System.Drawing.Point(578, 140);
            this.btnChooseExcel.Name = "btnChooseExcel";
            this.btnChooseExcel.Size = new System.Drawing.Size(37, 23);
            this.btnChooseExcel.TabIndex = 19;
            this.btnChooseExcel.Text = "...";
            this.btnChooseExcel.UseVisualStyleBackColor = true;
            this.btnChooseExcel.Click += new System.EventHandler(this.btnChooseExcel_Click);
            // 
            // btnChooseCsv
            // 
            this.btnChooseCsv.Location = new System.Drawing.Point(578, 183);
            this.btnChooseCsv.Name = "btnChooseCsv";
            this.btnChooseCsv.Size = new System.Drawing.Size(37, 23);
            this.btnChooseCsv.TabIndex = 22;
            this.btnChooseCsv.Text = "...";
            this.btnChooseCsv.UseVisualStyleBackColor = true;
            this.btnChooseCsv.Click += new System.EventHandler(this.btnChooseCsv_Click);
            // 
            // tbxCsvFile
            // 
            this.tbxCsvFile.Enabled = false;
            this.tbxCsvFile.Location = new System.Drawing.Point(143, 186);
            this.tbxCsvFile.Name = "tbxCsvFile";
            this.tbxCsvFile.Size = new System.Drawing.Size(429, 20);
            this.tbxCsvFile.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Choose CSV file:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(600, 50);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChooseDataSourceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(627, 310);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChooseCsv);
            this.Controls.Add(this.tbxCsvFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChooseExcel);
            this.Controls.Add(this.tbxExcelPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSqlTable);
            this.Controls.Add(this.tbxServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDatabase);
            this.Controls.Add(this.rbxCsv);
            this.Controls.Add(this.rbxExcel);
            this.Controls.Add(this.rbxSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseDataSourceFrm";
            this.Text = "Choose Data Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbxSQL;
        private System.Windows.Forms.RadioButton rbxExcel;
        private System.Windows.Forms.RadioButton rbxCsv;
        private System.Windows.Forms.TextBox tbxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSqlTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxExcelPath;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button btnChooseExcel;
        private System.Windows.Forms.Button btnChooseCsv;
        private System.Windows.Forms.TextBox tbxCsvFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialogCsv;
        private System.Windows.Forms.Button btnSave;
    }
}
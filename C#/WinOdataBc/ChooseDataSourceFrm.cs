using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;

namespace WinOdataBc
{
    public partial class ChooseDataSourceFrm : Form
    {
        private Setup setup;

        public ChooseDataSourceFrm(Setup setup)
        {
            InitializeComponent();
            this.setup = setup;
            tbxServerName.Text = setup.server;
            tbxCsvFile.Text = setup.csvPath;
            tbxExcelPath.Text = setup.excelPath;
            cbxDatabase.Text = setup.database;
            cbxSqlTable.Text = setup.sqlTable;
            switch (setup.type)
            {
                case Library.Type.SQL:
                    rbxSQL.Checked = true;
                    break;
                case Library.Type.CSV:
                    rbxCsv.Checked = true;
                    break;
                case Library.Type.Excel:
                    rbxExcel.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void rbxSQL_CheckedChanged(object sender, EventArgs e)
        {
            if(rbxSQL.Checked)
            {
                tbxServerName.Enabled = true;
                cbxDatabase.Enabled = true;
                tbxExcelPath.Enabled = false;
                tbxCsvFile.Enabled = false;
                btnChooseCsv.Enabled = false;
                btnChooseExcel.Enabled = false;
                cbxSqlTable.Enabled = true;
                cbxDatabase.Enabled = true;
            }
        }

        private void rbxExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbxExcel.Checked)
            {
                tbxServerName.Enabled = false;
                cbxDatabase.Enabled = false;
                tbxExcelPath.Enabled = true;
                tbxCsvFile.Enabled = false;
                btnChooseCsv.Enabled = false;
                btnChooseExcel.Enabled = true;
                cbxSqlTable.Enabled = false;
                cbxDatabase.Enabled = false;
            }
        }

        private void rbxCsv_CheckedChanged(object sender, EventArgs e)
        {
            if (rbxCsv.Checked)
            {
                tbxServerName.Enabled = false;
                cbxDatabase.Enabled = false;
                tbxExcelPath.Enabled = false;
                tbxCsvFile.Enabled = true;
                btnChooseCsv.Enabled = true;
                btnChooseExcel.Enabled = false;
                cbxSqlTable.Enabled = false;
                cbxDatabase.Enabled = false;
            }
        }

        private void btnChooseExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxExcelPath.Text = openFileDialogExcel.FileName;
            }
        }

        private void btnChooseCsv_Click(object sender, EventArgs e)
        {
            if (openFileDialogCsv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxCsvFile.Text = openFileDialogCsv.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setup.server = tbxServerName.Text;
            setup.csvPath = tbxCsvFile.Text;
            setup.excelPath = tbxExcelPath.Text;
            setup.database = cbxDatabase.Text;
            setup.sqlTable = cbxSqlTable.Text;
            if (rbxCsv.Checked)
                setup.type = Library.Type.CSV;
            if (rbxSQL.Checked)
                setup.type = Library.Type.SQL;
            if (rbxExcel.Checked)
                setup.type = Library.Type.Excel;
            this.Close();
        }

        private void cbxSqlTable_DropDown(object sender, EventArgs e)
        {
            cbxSqlTable.Items.Clear();
            SqlConnection cnn;
            string connetionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + cbxDatabase.Text + ";Integrated Security=true;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            DataTable dt = cnn.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                cbxSqlTable.Items.Add(tablename);
            }
        }

        private void cbxDatabase_DropDown(object sender, EventArgs e)
        {
            string connetionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + cbxDatabase.Text + ";Integrated Security=true;";

            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cbxDatabase.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
        }
    }
}

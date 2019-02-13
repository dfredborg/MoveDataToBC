using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Library;
using Newtonsoft.Json;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;

namespace WinOdataBc
{
    public partial class MappingFrm : Form
    {
        private Setup setup;
        private List<CsvField> csvFieldList;
        private List<Values> varList;
        private List<CsvLine> csvLines;
        private List<ExcelLine> excelLines;
        int Count = 0;
        int lines = 0;
        private DateTime startDateTime;
        private DateTime endDateTime;
        public MappingFrm(Setup setup)
        {
            InitializeComponent();
            this.setup = setup;

        }

        private void MappingFrm_Load(object sender, EventArgs e)
        {
            ShowWaitForm();

            dataGridView.Rows.Clear();

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "From Field";
            cmb.Name = "cmb";
            cmb.MinimumWidth = 250;

            if (setup.type == Library.Type.SQL)
            {

                string connetionString = "Data Source=" + setup.server + ";Initial Catalog=" + setup.database + ";Integrated Security=true;";

                using (SqlConnection connection = new SqlConnection(connetionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '" + setup.sqlTable + "'";
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb.Items.Add(reader.GetString(0));
                        }
                    }
                }
                
            }

            if(setup.type == Library.Type.CSV)
            {
                csvFieldList = new List<CsvField>();
                csvLines = new List<CsvLine>();
                int j = 0;
                using (var reader = new StreamReader(setup.csvPath))
                {
                    List<string> csvfields = new List<string>();
                    bool first = true;
                    while (!reader.EndOfStream)
                    {
                        CsvLine csvLine = new CsvLine();
                        csvLine.csvFields = new List<CsvField>();
                        var line = reader.ReadLine();
                        string[] values = line.Split(';');
                        if (first)
                        {
                            csvfields = line.Split(';').ToList();
                            first = false;
                        }                            
                        else
                        {
                            for (int i = 0; i < csvfields.Count; i++)
                            {
                                csvLine.csvFields.Add(new CsvField { key = csvfields[i], index = i, value = values[i] });
                            }
                            csvLines.Add(csvLine);
                            _waitForm.updateLbl(j++);
                            _waitForm.Refresh();
                        }
                    }

                    foreach(string s in csvfields)
                    {
                        cmb.Items.Add(s);
                    }                    
                }

            }

            if(setup.type == Library.Type.Excel)
            {
                excelLines = new List<ExcelLine>();
                ExcelLine excelLine =  new ExcelLine();

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(setup.excelPath);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                List<string> headers = new List<string>();

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {

                        if(i == 1)
                        {
                            cmb.Items.Add(xlRange.Cells[i, j].Value2.ToString());
                            headers.Add(xlRange.Cells[i, j].Value2.ToString());
                        }
                        else
                        {
                            if (j == 1)
                            {
                                excelLine = new ExcelLine();
                                excelLine.excelFields = new List<ExcelField>();
                            }

                            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                                excelLine.excelFields.Add(new ExcelField{ key = headers[j-1], index = i, value = xlRange.Cells[i, j].Value2.ToString() });
                        }

                    }
                    if (i != 1)
                    {
                        excelLines.Add(excelLine);
                        _waitForm.updateLbl(i);
                        _waitForm.Refresh();
                    }
                        
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }

            dataGridView.Columns.Add(cmb);

            try
            {
                var client = new DataToBCService.DataToBc();
                client.Url = setup.webServiceUrl;
                client.Credentials = new NetworkCredential(setup.userName, setup.password);
                string fields = client.GetFields(setup.function, setup.direct);
                List<string> result = fields.Split(',').ToList();
                foreach (string s in result)
                {
                    this.dataGridView.Rows.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not vaild setup");
                Close();
            }
            

            
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            startDateTime = DateTime.Now;

            if(setup.type == Library.Type.SQL)
                PushSQL();

            if (setup.type == Library.Type.CSV)
                PushCSV();

            if (setup.type == Library.Type.Excel)
                PushExcel();

            int i = 0;
            int size = 10;
            int counter = 0;
            Count = varList.Count;

            List<Values> subList = new List<Values>();
            progressBarCustomer.Maximum = varList.Count;
            progressBarCustomer.Value = 0;
            bool createNew = true;
            foreach (Values values in varList)
            {
                counter++;
                lblProgress.Text = "Processing fields " + counter + " of " + Count + " ";
                lblProgress.Refresh();
                progressBarCustomer.Value += 1;
                progressBarCustomer.Refresh();

                if (createNew)
                    subList = new List<Values>();

                createNew = false;
                subList.Add(values);

                if (values.field == "InsertTrigger")
                {
                    if (i == size | counter == varList.Count )
                    {
                        string json = "";
                        json = JsonConvert.SerializeObject(subList);

                        var client = new DataToBCService.DataToBc();
                        client.Url = setup.webServiceUrl;
                        client.Credentials = new NetworkCredential(setup.userName, setup.password);
                        try
                        {
                            client.Create(setup.function, json, setup.direct);
                            createNew = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        i++;
                }
            }
            endDateTime = DateTime.Now;
            TimeSpan timeSpan = endDateTime - startDateTime;
            MessageBox.Show(lines + " Records Pushed To BC - Duration " + timeSpan.TotalMinutes);
        }



        private void PushSQL()
        {
            varList = new List<Values>();

            string connetionString = "Data Source=" + setup.server + ";Initial Catalog=" + setup.database + ";Integrated Security=true;";
            

            string Table = setup.sqlTable;
            if (Table.Contains('$'))
            {
                Table = "[" + Table + "]";
            }

            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select count(*) FROM " + Table;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        progressBarCustomer.Maximum = reader.GetInt32(0);
                        lines = reader.GetInt32(0);
                    }
                }
            }


            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select * FROM " + Table;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                Values value = new Values();
                                value.field = row.Cells[0].Value.ToString();
                                if (row.Cells[1].Value != null)
                                    value.value = reader[row.Cells[1].Value.ToString()].ToString();
                                else
                                    value.value = "";
                                varList.Add(value);
                            }

                        }
                        Values value2 = new Values();
                        value2.field = "InsertTrigger";
                        value2.value = "";
                        varList.Add(value2);
                        progressBarCustomer.Value += 1;
                        Count += 1;
                    }
                }
            }
        }

        private void PushCSV()
        {
            varList = new List<Values>();
            progressBarCustomer.Maximum = csvLines.Count;
            lines = csvLines.Count;
            foreach (CsvLine csvLine in csvLines)
            { 

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        Values value = new Values();
                        value.field = row.Cells[0].Value.ToString();
                        if (row.Cells[1].Value != null)
                        {
                            foreach(CsvField csvField in csvLine.csvFields)
                            {
                                if (csvField.key == row.Cells[1].Value.ToString())
                                        value.value = csvField.value;
                            }
                        }                                
                        else
                            value.value = "";
                        varList.Add(value);
                    }
                }

                Values value2 = new Values();
                value2.field = "InsertTrigger";
                value2.value = "";
                varList.Add(value2);
                progressBarCustomer.Value += 1;
                Count += 1;
            }

        }

        private void PushExcel()
        {
            varList = new List<Values>();
            progressBarCustomer.Maximum = excelLines.Count;
            lines = excelLines.Count;
            foreach (ExcelLine excelLine in excelLines)
            {

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        Values value = new Values();
                        value.field = row.Cells[0].Value.ToString();
                        if (row.Cells[1].Value != null)
                        {
                            foreach (ExcelField excelField in excelLine.excelFields)
                            {
                                if (excelField.key == row.Cells[1].Value.ToString())
                                    value.value = excelField.value;
                            }
                        }
                        else
                            value.value = "";
                        varList.Add(value);
                    }
                }

                Values value2 = new Values();
                value2.field = "InsertTrigger";
                value2.value = "";
                varList.Add(value2);
                progressBarCustomer.Value += 1;
                Count += 1;
                progressBarCustomer.Refresh();
            }

        }

        private WaitFrm _waitForm;

        protected void ShowWaitForm()
        {
            // don't display more than one wait form at a time
            if (_waitForm != null && !_waitForm.IsDisposed)
            {
                return;
            }

            _waitForm = new WaitFrm();
            _waitForm.TopMost = true;
            _waitForm.StartPosition = FormStartPosition.CenterScreen;
            _waitForm.Show();
            _waitForm.Refresh();

            // force the wait window to display for at least 700ms so it doesn't just flash on the screen
            System.Threading.Thread.Sleep(700);
            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;
            _waitForm.Refresh();
            _waitForm.Close();
        }
    }
}

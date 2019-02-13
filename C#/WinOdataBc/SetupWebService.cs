using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Library;

namespace WinOdataBc
{
    public partial class SetupWebService : Form
    {
        private Setup setup;
        public SetupWebService(Setup setup)
        {
            InitializeComponent();
            this.setup = setup;
            tbxWebServicePassword.Text = setup.password;
            tbxWebServiceUrl.Text = setup.webServiceUrl;
            tbxWebServiceUser.Text = setup.userName;
            cbxWebServiceDirect.Checked = setup.direct;
            cbxWebServiceFunctions.Text = setup.function;
        }

        private void cbxWebServiceFunctions_DropDown(object sender, EventArgs e)
        {
            cbxWebServiceFunctions.Items.Clear();
            var client = new DataToBCService.DataToBc();
            client.Url = tbxWebServiceUrl.Text;
            client.Credentials = new NetworkCredential(tbxWebServiceUser.Text, tbxWebServicePassword.Text);
            string fucntions = client.GetFunctions();
            List<string> result = fucntions.Split(',').ToList();

            foreach (string s in result)
            {
                cbxWebServiceFunctions.Items.Add(s);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setup.password = tbxWebServicePassword.Text;
            setup.webServiceUrl = tbxWebServiceUrl.Text;
            setup.userName = tbxWebServiceUser.Text;
            setup.direct = cbxWebServiceDirect.Checked;
            setup.function = cbxWebServiceFunctions.Text;
            Close();
        }
    }
}

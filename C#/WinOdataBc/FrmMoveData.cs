using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Library;
using Newtonsoft.Json;

namespace WinOdataBc
{
    public partial class FrmMoveData : Form
    {
        List<string> CustomerFields = new List<string>();
        private Setup setup;
        private MappingFrm mappingFrm;
        public FrmMoveData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setup = new Setup();

        }        

        private void btnChooseDataSource_Click(object sender, EventArgs e)
        {
            ChooseDataSourceFrm chooseDataSourceFrm = new ChooseDataSourceFrm(setup);
            chooseDataSourceFrm.ShowDialog();
        }

        private void btnSetupWebService_Click(object sender, EventArgs e)
        {
            SetupWebService setupWebService = new SetupWebService(setup);
            setupWebService.ShowDialog();
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            mappingFrm = new MappingFrm(setup);
            mappingFrm.ShowDialog();        
                       
        }
        

    }
}

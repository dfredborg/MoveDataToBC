using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinOdataBc
{
    public partial class WaitFrm : Form
    {
        public WaitFrm()
        {
            InitializeComponent();

            
        }

        public void updateLbl(int i)
        {
            lblLoading.Text = "Loading line " + i;
        }
    }
}

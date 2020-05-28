using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Globalization;
using Microsoft.VisualBasic.PowerPacks;

namespace BSP
{
    public partial class frmBudgetMaintenance : Form
    {
        ctrlFormTitle ctrlTitle;
        DataRepeater dataRepeater1;
        DataSet ds;


        public frmBudgetMaintenance()
        {
            InitializeComponent();
            ds = new DataSet();
            
        }

        private void FormatString(object sender, ConvertEventArgs cevent)
        {

            if (cevent.DesiredType != typeof(string))
            {
                cevent.Value = "0.00";
                return;
            }
            cevent.Value = Convert.ToDecimal(cevent.Value).ToString("N2", CultureInfo.InvariantCulture);
            
        }

        private void FrmBudgetMaintenance_Load(object sender, EventArgs e)
        {

        }
    }
}

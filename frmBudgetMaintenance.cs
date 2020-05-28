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
        Mysql conn = Mysql.Instance();
        string[] arrlbls = new string[] {"lblCurrency", "lblFacilityDescription", "lblFacility", "lblCommodityDescription", "lblCommodity"};

        public frmBudgetMaintenance()
        {
            InitializeComponent();
            DataTable dt = new DataTable();

            conn.DatabaseName = "YourDatabase";
            conn.IsConnect();
            dt = conn.GetDataTable("Select * from tblbudget");

            pnlContent.Visible = false;
            lblQty.DataBindings.Add("Text", dt, "Qty_123",true, DataSourceUpdateMode.OnValidation,"", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblHours.DataBindings.Add("Text", dt, "Direct_Hours", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblCurrency.DataBindings.Add("Text", dt, "Currency");
            lblEquipment.DataBindings.Add("Text", dt, "Equipment_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblVendor.DataBindings.Add("Text", dt, "Vendor_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblMaterials.DataBindings.Add("Text", dt, "Materials_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblFreight.DataBindings.Add("Text", dt, "Freight_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblLabour.DataBindings.Add("Text", dt, "Labour_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblDistribs.DataBindings.Add("Text", dt, "Distribs_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblEscalation.DataBindings.Add("Text", dt, "Escalation_Amount", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");
            lblTotal.DataBindings.Add("Text", dt, "TOTAL_COST", true, DataSourceUpdateMode.OnValidation, "", "{ 0:#,0.00; (0:#,0.00);0.00}");

            lblFacilityDescription.DataBindings.Add("Text", dt, "Facility_Description");
            lblFacility.DataBindings.Add("Text", dt, "New_Facility_Code");
            lblCommodityDescription.DataBindings.Add("Text", dt, "Commodity_Description");
            lblCommodity.DataBindings.Add("Text", dt, "New_Commodity_Code");

            ckAllocation.DataBindings.Add("Checked", dt, "Allocated");

            ckAllocation.CheckedChanged += ExternalChkBox_CheckChanged;

            
            txtPackage.DataBindings.Add("Text", dt, "Package");
            pnlContent.Visible = true;

            dataRepeater1.DataSource = dt;

            

        }

        private void ExternalChkBox_CheckChanged(object sender, EventArgs e)
        {
            // External trigger
            if (((CheckBox)dataRepeater1.CurrentItem.Controls["ckAllocation"]).Checked)
            {
                dataRepeater1.CurrentItem.Controls["txtPackage"].Enabled = false;
            } else
            {
                dataRepeater1.CurrentItem.Controls["txtPackage"].Enabled = true;
            }

        }

        private void FrmBudgetMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void FrmBudgetMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void DataRepeater1_DrawItem(object sender, DataRepeaterItemEventArgs e)
        {

            foreach (Control c in e.DataRepeaterItem.Controls)
            {
                if (!arrlbls.Contains(c.Name) && c.GetType() == typeof(Label))
                {
                    try
                    {
                        c.Text = string.Format("{0:#,0.00; (0:#,0.00);0.00}", Convert.ToDouble(c.Text));
                    }
                    catch
                    {
                        c.Text = "0.00";
                    }
                    continue;
                }

                if (c.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)c).Checked)
                    {
                        e.DataRepeaterItem.Controls["txtPackage"].Enabled = false;
                    }
                    continue;
                }
            }
            
            
        }

        private void CkAllocation_Validated(object sender, EventArgs e)
        {
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace BSP
{
    class Mysql
    {

        private Mysql()
        {
        }

        private string databaseName = string.Empty;
        private string filterString = string.Empty;

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string FilterString
        {
            get { return filterString; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static Mysql _instance = null;
        public static Mysql Instance()
        {
            if (_instance == null)
                _instance = new Mysql();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = Properties.Settings.Default.bspConnectionString.ToString();
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt;

        } 

        public DataTable FilterBudget(string sPackage, string sFacility, string sFacilityDesc, string sCommodity, string sCommodityDesc, string sTotal, string sAllocation)
        {
            filterString = string.Empty;
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter;

            if (!String.IsNullOrEmpty(sPackage.Trim()))
            {
                filterString = string.Format("Package LIKE '%{0}%' ", sPackage);                
            }

            if(filterString.Length != 0)
            {
                dataAdapter = new MySqlDataAdapter(string.Format("Select * FROM tblbudget WHERE {0}", filterString), connection);
            } else
            {
                dataAdapter = new MySqlDataAdapter(string.Format("Select * FROM tblbudget", filterString), connection);
            }

            dataAdapter.Fill(dt);
            return dt;

        }

        public void Close()
        {
            connection.Close();
        }

    }
}

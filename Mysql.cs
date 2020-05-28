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
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
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
                string connstring = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", "localhost", "3360", "root", "124@bc45", "bsp");
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql);
            dataAdapter.Fill(dt);
            return dt;

        } 

        public void Close()
        {
            connection.Close();
        }

    }
}

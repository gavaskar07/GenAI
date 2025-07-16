using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PH
{
    
    internal class dbutilities
    {
        public string strPath;
        OleDbConnection myconnection = new OleDbConnection();
        public dbutilities()
        {
            strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            strPath = strPath.Substring(6, strPath.Length - 6);
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            string datafile = strPath + "\\Database.accdb";
            myconnection.ConnectionString = provider + datafile;
        }
        // IUD
        public String iud(String query)
        {
            // set_connection_details();
            myconnection.Open();
            string command = query;
            OleDbCommand cmdd = new OleDbCommand(command, myconnection);
            int rowcount = cmdd.ExecuteNonQuery();
            myconnection.Close();
            if (rowcount > 0)
            {
                return "sucess";

            }
            else
            {
                return "error";

            }
        }
        public DataSet load_dataset(String query)
        {
            //set_connection_details();

            myconnection.Open();
            string queryString = query;
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, myconnection);
            DataSet data = new DataSet();
            adapter.Fill(data, "datatable");
            myconnection.Close();
            return data;
            //dg.DataSource = data.Tables[0];
        }
    }

}

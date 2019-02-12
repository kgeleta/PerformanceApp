using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceTester.classes
{
    class QueryTestResult
    {
        public String ComputerName { get; set; }
        public int LineNumber { get; set; }
        public long CpuTime { get; set; }
        public long ElapsedTime { get; set; }
        public long BytesReceived { get; set; }
        public long SelectRows { get; set; }
        public String AddTime { get; set; }

        static String connectionStr = ConfigurationManager.ConnectionStrings["PerformanceTester.Properties.Settings.kgeletaConnectionString"].ConnectionString;

        public static DataTable Select()
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            DataTable dataTable = new DataTable();
            try
            {
                String query = "use kgeleta; select * from Performance.DB order by ComputerName, LineNumber, AddTime desc;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                connection.Open();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static void FillComputerName(ComboBox box)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            try
            {
                String query = "use kgeleta; select distinct ComputerName from Performance.DB;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                // delete items from comboBox:
                box.Items.Clear();

                using (SqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            string item = objReader.GetString(objReader.GetOrdinal("ComputerName"));
                            box.Items.Add(item);
                        }
                    }
                }

            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable Search(String computerName, int lineNumber)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            DataTable dataTable = new DataTable();
            try
            {
                String query = "use kgeleta; select * from Performance.DB where ComputerName like '%" + computerName + "%'" +
                (lineNumber >= 0 ? " and LineNumber = " + lineNumber.ToString() + " " : " ") + "order by ComputerName, LineNumber, AddTime desc;";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                connection.Open();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

    }
}

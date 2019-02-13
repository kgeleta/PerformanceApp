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
    class LocalTestPlot
    {
        public String ComputerName { get; set; }
        public int LineNumber { get; set; }
        public long CpuTime { get; set; }
        public long CpuUsage { get; set; }
        public long ElapsedTime { get; set; }
        public String AddTime { get; set; }

        static String connectionStr = ConfigurationManager.ConnectionStrings["PerformanceTester.Properties.Settings.kgeletaConnectionString"].ConnectionString;

        public static void FillComputerName(ComboBox box)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            try
            {
                String query = "use kgeleta; select distinct ComputerName from Performance.DBLocal;";
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

        public static void FillLineNumber(ComboBox box)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            try
            {
                String query = "use kgeleta; select distinct LineNumber from Performance.DBLocal;";
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
                            int item = objReader.GetInt32(objReader.GetOrdinal("LineNumber"));
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

        public static void FillParameter(ComboBox box)
        {
            box.Items.Clear();
            box.Items.Add("CpuTime");
            box.Items.Add("CpuUsage");
            box.Items.Add("ElapsedTime");
        }

        public static List<String> Plot(String computerName, int lineNumber, String parameter)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            List<String> list = new List<String>();
            string time = "";
            string value = "";
            try
            {
                String query = "use kgeleta; select " + parameter + ", AddTime from Performance.DBLocal where ComputerName like '%" + computerName + "%'" +
                (lineNumber >= 0 ? " and LineNumber = " + lineNumber.ToString() + " " : " ") + "order by AddTime asc;";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    time = reader["AddTime"].ToString();
                    value = reader[parameter].ToString();
                    list.Add(time + "|" + value);
                }
            }
            catch (Exception e) { }
            finally
            {
                connection.Close();
            }
            return list;
        }

    }
}

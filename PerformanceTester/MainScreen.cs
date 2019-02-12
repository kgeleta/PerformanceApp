using PerformanceTester.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceTester
{
    public partial class MainScreen : Form
    {
        private String[] dgvDbInfo = {"", "Name of computer on\nwhich query was tested", "Line number or query ID", "Time taken by SQL server to complete the execution\nof the compiled plan (actual time spend on CPU)",
            "Total time to complete the execution which includes\nsignal wait time, wait time to complete the IO operation\nand time taken to transfer the output to the client", "Number of bytes client received", "Number of rows client selected", "Query execution time" };

        public MainScreen()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        // REFRESH BUTTON (DB LAYER):
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDatabase.DataSource = QueryTestResult.Select();
            QueryTestResult.FillComputerName(comboBoxComputerName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // LOAD:
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLocal_performance.DBLocal' table. You can move, or remove it, as needed.
            this.dBLocalTableAdapter1.Fill(this.dBLocal_performance.DBLocal);
            // TODO: This line of code loads data into the 'dB_performance.DB' table. You can move, or remove it, as needed.
            this.dBTableAdapter1.Fill(this.dB_performance.DB);
            

            // TEST:
            //dataGridViewDatabase.DataSource = QueryTestResult.Select();
            //dataGridViewBusiness.DataSource = LocalTestResult.Select();

            QueryTestResult.FillComputerName(comboBoxComputerName);
            LocalTestResult.FillComputerName(comboBoxComputerNameBusiness);

            foreach (DataGridViewColumn c in this.dataGridViewDatabase.Columns)
            {
                c.ToolTipText = dgvDbInfo[c.Index + 1]; //string.Format("info: {0}", c.Index + 1);
            }

            numericUpDownLineNumber.Text = "";
            numericUpDownLineBusiness.Text = "";

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        // REFRESH BUTTON (LOCAL):
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewBusiness.DataSource = LocalTestResult.Select();
            LocalTestResult.FillComputerName(comboBoxComputerNameBusiness);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String computerName = (String)comboBoxComputerName.SelectedItem;
            int lineNumber = (numericUpDownLineNumber.Text == "" ? -1 : (int)numericUpDownLineNumber.Value);

            dataGridViewDatabase.DataSource = QueryTestResult.Search(computerName, lineNumber);
        }

        private void comboBoxComputerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // SEARCH LOCAL:
        private void buttonSearchBusiness_Click(object sender, EventArgs e)
        {
            String computerName = (String)comboBoxComputerNameBusiness.SelectedItem;
            int lineNumber = (numericUpDownLineBusiness.Text == "" ? -1 : (int)numericUpDownLineBusiness.Value);

            dataGridViewBusiness.DataSource = LocalTestResult.Search(computerName, lineNumber);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresentation_Click(object sender, EventArgs e)
        {
            
        }
    }
}

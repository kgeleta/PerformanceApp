namespace PerformanceTester
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelLineNumber = new System.Windows.Forms.Label();
            this.numericUpDownLineNumber = new System.Windows.Forms.NumericUpDown();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.comboBoxComputerName = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchBusiness = new System.Windows.Forms.Button();
            this.comboBoxComputerNameBusiness = new System.Windows.Forms.ComboBox();
            this.numericUpDownLineBusiness = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewBusiness = new System.Windows.Forms.DataGridView();
            this.refreshBusiness = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonPresentation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPresentation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dB_performance = new PerformanceTester.DB_performance();
            this.dBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTableAdapter1 = new PerformanceTester.DB_performanceTableAdapters.DBTableAdapter();
            this.computerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elapsedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytesReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowsSelectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBLocal_performance = new PerformanceTester.DBLocal_performance();
            this.dBLocalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBLocalTableAdapter1 = new PerformanceTester.DBLocal_performanceTableAdapters.DBLocalTableAdapter();
            this.computerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpuUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elapsedTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_performance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLocal_performance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLocalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelLineNumber);
            this.tabPage1.Controls.Add(this.numericUpDownLineNumber);
            this.tabPage1.Controls.Add(this.labelComputerName);
            this.tabPage1.Controls.Add(this.comboBoxComputerName);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.dataGridViewDatabase);
            this.tabPage1.Controls.Add(this.refreshButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Access Layer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelLineNumber
            // 
            this.labelLineNumber.AutoSize = true;
            this.labelLineNumber.Location = new System.Drawing.Point(284, 48);
            this.labelLineNumber.Name = "labelLineNumber";
            this.labelLineNumber.Size = new System.Drawing.Size(70, 13);
            this.labelLineNumber.TabIndex = 10;
            this.labelLineNumber.Text = "Line Number:";
            // 
            // numericUpDownLineNumber
            // 
            this.numericUpDownLineNumber.Location = new System.Drawing.Point(287, 70);
            this.numericUpDownLineNumber.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDownLineNumber.Name = "numericUpDownLineNumber";
            this.numericUpDownLineNumber.Size = new System.Drawing.Size(129, 20);
            this.numericUpDownLineNumber.TabIndex = 8;
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Location = new System.Drawing.Point(284, 97);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(86, 13);
            this.labelComputerName.TabIndex = 7;
            this.labelComputerName.Text = "Computer Name:";
            this.labelComputerName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxComputerName
            // 
            this.comboBoxComputerName.FormattingEnabled = true;
            this.comboBoxComputerName.Location = new System.Drawing.Point(287, 113);
            this.comboBoxComputerName.Name = "comboBoxComputerName";
            this.comboBoxComputerName.Size = new System.Drawing.Size(196, 21);
            this.comboBoxComputerName.TabIndex = 6;
            this.comboBoxComputerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxComputerName_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(434, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 42);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AllowUserToAddRows = false;
            this.dataGridViewDatabase.AllowUserToDeleteRows = false;
            this.dataGridViewDatabase.AllowUserToOrderColumns = true;
            this.dataGridViewDatabase.AutoGenerateColumns = false;
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computerNameDataGridViewTextBoxColumn,
            this.lineNumberDataGridViewTextBoxColumn,
            this.cpuTimeDataGridViewTextBoxColumn,
            this.elapsedTimeDataGridViewTextBoxColumn,
            this.bytesReceivedDataGridViewTextBoxColumn,
            this.rowsSelectedDataGridViewTextBoxColumn,
            this.addTimeDataGridViewTextBoxColumn});
            this.dataGridViewDatabase.DataSource = this.dBBindingSource2;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(8, 155);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.ReadOnly = true;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(791, 296);
            this.dataGridViewDatabase.TabIndex = 3;
            this.dataGridViewDatabase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatabase_CellContentClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(22, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(238, 111);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonSearchBusiness);
            this.tabPage2.Controls.Add(this.comboBoxComputerNameBusiness);
            this.tabPage2.Controls.Add(this.numericUpDownLineBusiness);
            this.tabPage2.Controls.Add(this.dataGridViewBusiness);
            this.tabPage2.Controls.Add(this.refreshBusiness);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Business Layer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Line Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonSearchBusiness
            // 
            this.buttonSearchBusiness.Location = new System.Drawing.Point(434, 48);
            this.buttonSearchBusiness.Name = "buttonSearchBusiness";
            this.buttonSearchBusiness.Size = new System.Drawing.Size(91, 42);
            this.buttonSearchBusiness.TabIndex = 4;
            this.buttonSearchBusiness.Text = "Search";
            this.buttonSearchBusiness.UseVisualStyleBackColor = true;
            this.buttonSearchBusiness.Click += new System.EventHandler(this.buttonSearchBusiness_Click);
            // 
            // comboBoxComputerNameBusiness
            // 
            this.comboBoxComputerNameBusiness.FormattingEnabled = true;
            this.comboBoxComputerNameBusiness.Location = new System.Drawing.Point(287, 113);
            this.comboBoxComputerNameBusiness.Name = "comboBoxComputerNameBusiness";
            this.comboBoxComputerNameBusiness.Size = new System.Drawing.Size(196, 21);
            this.comboBoxComputerNameBusiness.TabIndex = 3;
            // 
            // numericUpDownLineBusiness
            // 
            this.numericUpDownLineBusiness.Location = new System.Drawing.Point(287, 70);
            this.numericUpDownLineBusiness.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDownLineBusiness.Name = "numericUpDownLineBusiness";
            this.numericUpDownLineBusiness.Size = new System.Drawing.Size(129, 20);
            this.numericUpDownLineBusiness.TabIndex = 2;
            // 
            // dataGridViewBusiness
            // 
            this.dataGridViewBusiness.AllowUserToAddRows = false;
            this.dataGridViewBusiness.AllowUserToDeleteRows = false;
            this.dataGridViewBusiness.AllowUserToOrderColumns = true;
            this.dataGridViewBusiness.AutoGenerateColumns = false;
            this.dataGridViewBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusiness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computerNameDataGridViewTextBoxColumn1,
            this.lineNumberDataGridViewTextBoxColumn1,
            this.cpuTimeDataGridViewTextBoxColumn1,
            this.cpuUsageDataGridViewTextBoxColumn,
            this.elapsedTimeDataGridViewTextBoxColumn1,
            this.addTimeDataGridViewTextBoxColumn1});
            this.dataGridViewBusiness.DataSource = this.dBLocalBindingSource1;
            this.dataGridViewBusiness.Location = new System.Drawing.Point(8, 155);
            this.dataGridViewBusiness.Name = "dataGridViewBusiness";
            this.dataGridViewBusiness.ReadOnly = true;
            this.dataGridViewBusiness.Size = new System.Drawing.Size(791, 296);
            this.dataGridViewBusiness.TabIndex = 1;
            // 
            // refreshBusiness
            // 
            this.refreshBusiness.Location = new System.Drawing.Point(22, 23);
            this.refreshBusiness.Name = "refreshBusiness";
            this.refreshBusiness.Size = new System.Drawing.Size(238, 111);
            this.refreshBusiness.TabIndex = 0;
            this.refreshBusiness.Text = "Refresh";
            this.refreshBusiness.UseVisualStyleBackColor = true;
            this.refreshBusiness.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonPresentation);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxPresentation);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage3.Size = new System.Drawing.Size(807, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Presentation Layer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonPresentation
            // 
            this.buttonPresentation.Location = new System.Drawing.Point(588, 53);
            this.buttonPresentation.Name = "buttonPresentation";
            this.buttonPresentation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPresentation.Size = new System.Drawing.Size(75, 23);
            this.buttonPresentation.TabIndex = 3;
            this.buttonPresentation.Text = "test";
            this.buttonPresentation.UseVisualStyleBackColor = true;
            this.buttonPresentation.Click += new System.EventHandler(this.buttonPresentation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "URL:";
            // 
            // textBoxPresentation
            // 
            this.textBoxPresentation.Location = new System.Drawing.Point(69, 55);
            this.textBoxPresentation.Name = "textBoxPresentation";
            this.textBoxPresentation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPresentation.Size = new System.Drawing.Size(504, 20);
            this.textBoxPresentation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 24);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Measure request, response and total time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dB_performance
            // 
            this.dB_performance.DataSetName = "DB_performance";
            this.dB_performance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBindingSource2
            // 
            this.dBBindingSource2.DataMember = "DB";
            this.dBBindingSource2.DataSource = this.dB_performance;
            // 
            // dBTableAdapter1
            // 
            this.dBTableAdapter1.ClearBeforeFill = true;
            // 
            // computerNameDataGridViewTextBoxColumn
            // 
            this.computerNameDataGridViewTextBoxColumn.DataPropertyName = "ComputerName";
            this.computerNameDataGridViewTextBoxColumn.HeaderText = "ComputerName";
            this.computerNameDataGridViewTextBoxColumn.Name = "computerNameDataGridViewTextBoxColumn";
            this.computerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNumberDataGridViewTextBoxColumn
            // 
            this.lineNumberDataGridViewTextBoxColumn.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.HeaderText = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.Name = "lineNumberDataGridViewTextBoxColumn";
            this.lineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpuTimeDataGridViewTextBoxColumn
            // 
            this.cpuTimeDataGridViewTextBoxColumn.DataPropertyName = "CpuTime";
            this.cpuTimeDataGridViewTextBoxColumn.HeaderText = "CpuTime";
            this.cpuTimeDataGridViewTextBoxColumn.Name = "cpuTimeDataGridViewTextBoxColumn";
            this.cpuTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elapsedTimeDataGridViewTextBoxColumn
            // 
            this.elapsedTimeDataGridViewTextBoxColumn.DataPropertyName = "ElapsedTime";
            this.elapsedTimeDataGridViewTextBoxColumn.HeaderText = "ElapsedTime";
            this.elapsedTimeDataGridViewTextBoxColumn.Name = "elapsedTimeDataGridViewTextBoxColumn";
            this.elapsedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bytesReceivedDataGridViewTextBoxColumn
            // 
            this.bytesReceivedDataGridViewTextBoxColumn.DataPropertyName = "BytesReceived";
            this.bytesReceivedDataGridViewTextBoxColumn.HeaderText = "BytesReceived";
            this.bytesReceivedDataGridViewTextBoxColumn.Name = "bytesReceivedDataGridViewTextBoxColumn";
            this.bytesReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowsSelectedDataGridViewTextBoxColumn
            // 
            this.rowsSelectedDataGridViewTextBoxColumn.DataPropertyName = "RowsSelected";
            this.rowsSelectedDataGridViewTextBoxColumn.HeaderText = "RowsSelected";
            this.rowsSelectedDataGridViewTextBoxColumn.Name = "rowsSelectedDataGridViewTextBoxColumn";
            this.rowsSelectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addTimeDataGridViewTextBoxColumn
            // 
            this.addTimeDataGridViewTextBoxColumn.DataPropertyName = "AddTime";
            this.addTimeDataGridViewTextBoxColumn.HeaderText = "AddTime";
            this.addTimeDataGridViewTextBoxColumn.Name = "addTimeDataGridViewTextBoxColumn";
            this.addTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dBLocal_performance
            // 
            this.dBLocal_performance.DataSetName = "DBLocal_performance";
            this.dBLocal_performance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBLocalBindingSource1
            // 
            this.dBLocalBindingSource1.DataMember = "DBLocal";
            this.dBLocalBindingSource1.DataSource = this.dBLocal_performance;
            // 
            // dBLocalTableAdapter1
            // 
            this.dBLocalTableAdapter1.ClearBeforeFill = true;
            // 
            // computerNameDataGridViewTextBoxColumn1
            // 
            this.computerNameDataGridViewTextBoxColumn1.DataPropertyName = "ComputerName";
            this.computerNameDataGridViewTextBoxColumn1.HeaderText = "ComputerName";
            this.computerNameDataGridViewTextBoxColumn1.Name = "computerNameDataGridViewTextBoxColumn1";
            this.computerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lineNumberDataGridViewTextBoxColumn1
            // 
            this.lineNumberDataGridViewTextBoxColumn1.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn1.HeaderText = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn1.Name = "lineNumberDataGridViewTextBoxColumn1";
            this.lineNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cpuTimeDataGridViewTextBoxColumn1
            // 
            this.cpuTimeDataGridViewTextBoxColumn1.DataPropertyName = "CpuTime";
            this.cpuTimeDataGridViewTextBoxColumn1.HeaderText = "CpuTime";
            this.cpuTimeDataGridViewTextBoxColumn1.Name = "cpuTimeDataGridViewTextBoxColumn1";
            this.cpuTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cpuUsageDataGridViewTextBoxColumn
            // 
            this.cpuUsageDataGridViewTextBoxColumn.DataPropertyName = "CpuUsage";
            this.cpuUsageDataGridViewTextBoxColumn.HeaderText = "CpuUsage";
            this.cpuUsageDataGridViewTextBoxColumn.Name = "cpuUsageDataGridViewTextBoxColumn";
            this.cpuUsageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elapsedTimeDataGridViewTextBoxColumn1
            // 
            this.elapsedTimeDataGridViewTextBoxColumn1.DataPropertyName = "ElapsedTime";
            this.elapsedTimeDataGridViewTextBoxColumn1.HeaderText = "ElapsedTime";
            this.elapsedTimeDataGridViewTextBoxColumn1.Name = "elapsedTimeDataGridViewTextBoxColumn1";
            this.elapsedTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addTimeDataGridViewTextBoxColumn1
            // 
            this.addTimeDataGridViewTextBoxColumn1.DataPropertyName = "AddTime";
            this.addTimeDataGridViewTextBoxColumn1.HeaderText = "AddTime";
            this.addTimeDataGridViewTextBoxColumn1.Name = "addTimeDataGridViewTextBoxColumn1";
            this.addTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 483);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Performance Tester";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_performance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLocal_performance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLocalBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.Button refreshBusiness;
        private System.Windows.Forms.DataGridView dataGridViewBusiness;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxComputerName;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.NumericUpDown numericUpDownLineNumber;
        private System.Windows.Forms.Label labelLineNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchBusiness;
        private System.Windows.Forms.ComboBox comboBoxComputerNameBusiness;
        private System.Windows.Forms.NumericUpDown numericUpDownLineBusiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPresentation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPresentation;
        private DB_performance dB_performance;
        private System.Windows.Forms.BindingSource dBBindingSource2;
        private DB_performanceTableAdapters.DBTableAdapter dBTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elapsedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bytesReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowsSelectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTimeDataGridViewTextBoxColumn;
        private DBLocal_performance dBLocal_performance;
        private System.Windows.Forms.BindingSource dBLocalBindingSource1;
        private DBLocal_performanceTableAdapters.DBLocalTableAdapter dBLocalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpuUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elapsedTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTimeDataGridViewTextBoxColumn1;
    }
}


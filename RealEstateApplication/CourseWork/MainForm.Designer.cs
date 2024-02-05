namespace CourseWork
{
    partial class MainForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.realEstateOrganizationDbDataSet = new CourseWork.RealEstateOrganizationDbDataSet();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new CourseWork.RealEstateOrganizationDbDataSetTableAdapters.PropertiesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaseAgreementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenFIlterWindow = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonClearResult = new System.Windows.Forms.Button();
            this.comboBoxSortOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxSortField = new System.Windows.Forms.ComboBox();
            this.buttonApplySorting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.yearReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateOrganizationDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.realEstateOrganizationDbDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // realEstateOrganizationDbDataSet
            // 
            this.realEstateOrganizationDbDataSet.DataSetName = "RealEstateOrganizationDbDataSet";
            this.realEstateOrganizationDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Dubai", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Address",
            "Size,",
            "Price"});
            this.comboBoxSearch.Location = new System.Drawing.Point(12, 306);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(331, 53);
            this.comboBoxSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Dubai", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 226);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(331, 53);
            this.textBoxSearch.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(12, 378);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(331, 103);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.bindingSource1;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.leaseAgreementsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2224, 46);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.propertiesToolStripMenuItem.Text = "Properties Managment";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // leaseAgreementsToolStripMenuItem
            // 
            this.leaseAgreementsToolStripMenuItem.Name = "leaseAgreementsToolStripMenuItem";
            this.leaseAgreementsToolStripMenuItem.Size = new System.Drawing.Size(222, 38);
            this.leaseAgreementsToolStripMenuItem.Text = "LeaseAgreements";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // buttonOpenFIlterWindow
            // 
            this.buttonOpenFIlterWindow.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFIlterWindow.Location = new System.Drawing.Point(548, 378);
            this.buttonOpenFIlterWindow.Name = "buttonOpenFIlterWindow";
            this.buttonOpenFIlterWindow.Size = new System.Drawing.Size(331, 103);
            this.buttonOpenFIlterWindow.TabIndex = 6;
            this.buttonOpenFIlterWindow.Text = "Add Filter";
            this.buttonOpenFIlterWindow.UseVisualStyleBackColor = true;
            this.buttonOpenFIlterWindow.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 509);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 82;
            this.dataGridViewMain.RowTemplate.Height = 33;
            this.dataGridViewMain.Size = new System.Drawing.Size(1438, 1161);
            this.dataGridViewMain.TabIndex = 7;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
            // 
            // buttonClearResult
            // 
            this.buttonClearResult.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearResult.Location = new System.Drawing.Point(1471, 509);
            this.buttonClearResult.Name = "buttonClearResult";
            this.buttonClearResult.Size = new System.Drawing.Size(331, 103);
            this.buttonClearResult.TabIndex = 8;
            this.buttonClearResult.Text = "ClearResults";
            this.buttonClearResult.UseVisualStyleBackColor = true;
            this.buttonClearResult.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.Font = new System.Drawing.Font("Dubai", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortOrder.FormattingEnabled = true;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.Location = new System.Drawing.Point(1107, 306);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(331, 53);
            this.comboBoxSortOrder.TabIndex = 9;
            // 
            // comboBoxSortField
            // 
            this.comboBoxSortField.Font = new System.Drawing.Font("Dubai", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortField.FormattingEnabled = true;
            this.comboBoxSortField.Items.AddRange(new object[] {
            "Address",
            "Size",
            "PropertyTypeName",
            "Rent"});
            this.comboBoxSortField.Location = new System.Drawing.Point(1107, 226);
            this.comboBoxSortField.Name = "comboBoxSortField";
            this.comboBoxSortField.Size = new System.Drawing.Size(331, 53);
            this.comboBoxSortField.TabIndex = 10;
            this.comboBoxSortField.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonApplySorting
            // 
            this.buttonApplySorting.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplySorting.Location = new System.Drawing.Point(1107, 378);
            this.buttonApplySorting.Name = "buttonApplySorting";
            this.buttonApplySorting.Size = new System.Drawing.Size(331, 103);
            this.buttonApplySorting.TabIndex = 11;
            this.buttonApplySorting.Text = "Sort";
            this.buttonApplySorting.UseVisualStyleBackColor = true;
            this.buttonApplySorting.Click += new System.EventHandler(this.buttonApplySorting_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1177, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sort Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 54);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filter Panel";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearReportToolStripMenuItem,
            this.monthReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 90);
            this.label4.TabIndex = 14;
            this.label4.Text = "Properies ";
            // 
            // yearReportToolStripMenuItem
            // 
            this.yearReportToolStripMenuItem.Name = "yearReportToolStripMenuItem";
            this.yearReportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.yearReportToolStripMenuItem.Text = "Year Report";
            this.yearReportToolStripMenuItem.Click += new System.EventHandler(this.yearReportToolStripMenuItem_Click);
            // 
            // monthReportToolStripMenuItem
            // 
            this.monthReportToolStripMenuItem.Name = "monthReportToolStripMenuItem";
            this.monthReportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.monthReportToolStripMenuItem.Text = "Month Report";
            this.monthReportToolStripMenuItem.Click += new System.EventHandler(this.monthReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(2224, 1667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonApplySorting);
            this.Controls.Add(this.comboBoxSortField);
            this.Controls.Add(this.comboBoxSortOrder);
            this.Controls.Add(this.buttonClearResult);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonOpenFIlterWindow);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateOrganizationDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private RealEstateOrganizationDbDataSet realEstateOrganizationDbDataSet;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private RealEstateOrganizationDbDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaseAgreementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenFIlterWindow;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonClearResult;
        private System.Windows.Forms.ComboBox comboBoxSortOrder;
        private System.Windows.Forms.ComboBox comboBoxSortField;
        private System.Windows.Forms.Button buttonApplySorting;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem yearReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthReportToolStripMenuItem;
    }
}


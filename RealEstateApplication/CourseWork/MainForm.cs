using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{

    public partial class MainForm : Form
    {
        const string connectionString = @"Data Source=DESKTOP-6SUI740;Initial Catalog=RealEstateOrganizationDb;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
            LoadPropertyTypesWithDataGrid();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateOrganizationDbDataSet.Properties' table. You can move, or remove it, as needed.

            //this.propertiesTableAdapter.Fill(this.realEstateOrganizationDbDataSet.Properties);


        }
        private void LoadPropertyTypesWithDataGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL query with INNER JOIN to combine Properties and PropertyTypes
                string sql = @"
                                SELECT p.PropertyID, p.Address, p.Size, p.Rent, p.TypeID, pt.Name as PropertyTypeName
                                FROM Properties p
                                INNER JOIN PropertyTypes pt ON p.TypeID = pt.TypeID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dataGridViewMain.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedField = comboBoxSearch.SelectedItem.ToString();
            string searchText = textBoxSearch.Text;
            SearchProperties(selectedField, searchText);
        }

        private void SearchProperties(string field, string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $@"
                    SELECT p.PropertyID, p.Address, p.Size, p.Rent, p.TypeID, pt.Name as PropertyTypeName
                    FROM Properties p
                    INNER JOIN PropertyTypes pt ON p.TypeID = pt.TypeID
                    WHERE p.{field} LIKE @query";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@query", $"%{query}%");

                DataTable dataTable = new DataTable();
                try
                {

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    dataGridViewMain.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (FilterWindow filterForm = new FilterWindow())
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    FilterProperties(filterForm.PriceFrom, filterForm.PriceTo, filterForm.SizeFrom, filterForm.SizeTo);
                }
            }
        }

        private void FilterProperties(decimal? priceFrom, decimal? priceTo, int? sizeFrom, int? sizeTo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                                SELECT p.PropertyID, p.Address, p.Size, p.Rent, p.TypeID,  pt.Name as PropertyTypeName
                                FROM Properties p
                                INNER JOIN PropertyTypes pt ON p.TypeID = pt.TypeID
                                WHERE (@priceFrom IS NULL OR p.Rent >= @priceFrom)
                                AND (@priceTo IS NULL OR p.Rent <= @priceTo)
                                AND (@sizeFrom IS NULL OR p.Size >= @sizeFrom)
                                AND (@sizeTo IS NULL OR p.Size <= @sizeTo)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@priceFrom", (object)priceFrom ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@priceTo", (object)priceTo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sizeFrom", (object)sizeFrom ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sizeTo", (object)sizeTo ?? DBNull.Value);

                DataTable dataTable = new DataTable();
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    dataGridViewMain.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadPropertyTypesWithDataGrid();
        }

        // Method to handle sorting
        private void ApplySorting()
        {
            string selectedField = comboBoxSortField.SelectedItem.ToString();
            string sortOrder = comboBoxSortOrder.SelectedItem.ToString();

            SortProperties(selectedField, sortOrder);
        }

        private void SortProperties(string field, string order)
        {
            string sqlOrder = order == "Ascending" ? "ASC" : "DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $@"
                SELECT p.PropertyID, p.Address, p.Size, p.Rent, p.TypeID, pt.Name as PropertyTypeName
                FROM Properties p
                INNER JOIN PropertyTypes pt ON p.TypeID = pt.TypeID
                ORDER BY p.{field} {sqlOrder}";

                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    dataGridViewMain.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplySorting_Click(object sender, EventArgs e)
        {
            ApplySorting();
        }

        private void propertiesWithTheHighestRentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stat = new StatisticWindow();
            stat.ShowDialog();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stat = new QueryForm();
            stat.ShowDialog();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prop = new PropertiesManagmentForm();
            prop.ShowDialog();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yearReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnualSalesReportForm reportForm = new AnnualSalesReportForm();
            reportForm.ShowDialog();
        }

        private void monthReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthSalesReportForm reportForm = new MonthSalesReportForm();
            reportForm.ShowDialog();
        }
    }
}

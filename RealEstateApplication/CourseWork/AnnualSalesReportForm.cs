using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AnnualSalesReportForm : Form
    {
        const string connectionString = @"Data Source=DESKTOP-6SUI740;Initial Catalog=RealEstateOrganizationDb;Integrated Security=True";
        private DataTable dataTable;
        public AnnualSalesReportForm()
        {
            InitializeComponent();
            LoadAnnualSalesReport();
        }
        private void LoadAnnualSalesReport()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT 
                    PropertyID,
                    SUM(RentAmount) as TotalIncome,
                    COUNT(*) as NumberOfLeases
                FROM LeaseAgreements
                WHERE StartDate >= DATEADD(year, -1, GETDATE())
                GROUP BY PropertyID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewAnnualReport.DataSource = dataTable;
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save an Annual Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write column headers
                    string[] columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                    sw.WriteLine(string.Join(", ", columnNames));

                    // Write rows of data
                    foreach (DataRow row in dataTable.Rows)
                    {
                        sw.WriteLine(string.Join(", ", row.ItemArray.Select(item => item.ToString())));
                    }
                }
                MessageBox.Show("Report saved successfully.");
            }
        }
    }
}

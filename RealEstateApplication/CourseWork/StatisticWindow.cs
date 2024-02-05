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
    public partial class StatisticWindow : Form
    {
        const string connectionString = @"Data Source=DESKTOP-6SUI740;Initial Catalog=RealEstateOrganizationDb;Integrated Security=True";

        public StatisticWindow()
        {
            InitializeComponent();
        }

        private void btnLongestRentedTypes_Click(object sender, EventArgs e)
        {
            caption.Text = "The longest rented property types";
            string sql = @"
            SELECT TOP 5 pt.Name, SUM(DATEDIFF(day, la.StartDate, la.EndDate)) as TotalDaysRented
            FROM LeaseAgreements la
            JOIN Properties p ON la.PropertyID = p.PropertyID
            JOIN PropertyTypes pt ON p.TypeID = pt.TypeID
            GROUP BY pt.Name
            ORDER BY TotalDaysRented DESC";
            ExecuteQueryAndDisplayResults(sql);
        }

        private void btnTopTenantsByRent_Click(object sender, EventArgs e)
        {
            caption.Text = "The top tenants by rent price spent";
            string sql = @"
            SELECT TOP 5 t.Name, SUM(la.RentAmount) as TotalRentPaid
            FROM Tenants t
            JOIN LeaseAgreements la ON t.TenantID = la.TenantID
            GROUP BY t.Name
            ORDER BY TotalRentPaid DESC";
            ExecuteQueryAndDisplayResults(sql);
        }

        private void btnPopularPropertyTypes_Click(object sender, EventArgs e)
        {
            caption.Text = "The top popular property types";
            string sql = @"
            SELECT TOP 5 pt.Name, COUNT(la.LeaseID) as LeaseCount
            FROM PropertyTypes pt
            JOIN Properties p ON pt.TypeID = p.TypeID
            JOIN LeaseAgreements la ON p.PropertyID = la.PropertyID
            GROUP BY pt.Name
            ORDER BY LeaseCount DESC";
            ExecuteQueryAndDisplayResults(sql);
        }

        private void btnProfitableTenantTypes_Click(object sender, EventArgs e)
        {
            caption.Text = "The top profitable tenant types";
            string sql = @"
            SELECT TOP 5 tt.Name, SUM(la.RentAmount) as TotalRentCollected
            FROM TenantTypes tt
            JOIN Tenants t ON tt.TenantTypeID = t.TenantTypeID
            JOIN LeaseAgreements la ON t.TenantID = la.TenantID
            GROUP BY tt.Name
            ORDER BY TotalRentCollected DESC";
            ExecuteQueryAndDisplayResults(sql);
        }

        private void ExecuteQueryAndDisplayResults(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dataGridViewStatistics.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

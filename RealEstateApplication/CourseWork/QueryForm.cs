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
    public partial class QueryForm : Form
    {
        const string connectionString = @"Data Source=DESKTOP-6SUI740;Initial Catalog=RealEstateOrganizationDb;Integrated Security=True";

        public QueryForm()
        {
            InitializeComponent();
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            ExecuteArbitraryQuery(txtQuery.Text);
        }

        private void ExecuteArbitraryQuery(string sql)
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
                    dataGridViewQueryResults.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtQuery.Clear();
            txtQuery.Text = "Select";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

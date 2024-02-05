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
    public partial class PropertiesManagmentForm : Form
    {
        private Dictionary<int, string> propertyTypeDict = new Dictionary<int, string>();
        const string connectionString = @"Data Source=DESKTOP-6SUI740;Initial Catalog=RealEstateOrganizationDb;Integrated Security=True";
        public PropertiesManagmentForm()
        {
            InitializeComponent();
            LoadPropertyTypesWithDataGrid();
            LoadPropertyTypes();
        }

        private void PropertiesManagmentForm_Load(object sender, EventArgs e)
        {

        }

        

        private void LoadPropertyTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT TypeID, Name FROM PropertyTypes";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int typeId = reader.GetInt32(0);
                            string typeName = reader.GetString(1);
                            propertyTypeDict.Add(typeId, typeName);
                            comboBoxPropertyTypes.Items.Add(typeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int GetSelectedPropertyTypeId(string typeName)
        {
            foreach (var kvp in propertyTypeDict)
            {
                if (kvp.Value == typeName)
                {
                    return kvp.Key;
                }
            }
            return -1; // or handle as appropriate
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Properties (Address, Size, TypeID, Rent) VALUES (@Address, @Size, @TypeID, @Rent)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Size", Convert.ToInt32(txtSize.Text));
                    int selectedTypeId = GetSelectedPropertyTypeId(comboBoxPropertyTypes.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TypeID", Convert.ToInt32(selectedTypeId));
                    cmd.Parameters.AddWithValue("@Rent", Convert.ToDecimal(txtRent.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadPropertyTypesWithDataGrid(); // Refresh the DataGridView
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Properties SET Address = @Address, Size = @Size, TypeID = @TypeID, Rent = @Rent WHERE PropertyID = @PropertyID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", txtID.Text); // Assuming you have the ID of the selected property
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Size", Convert.ToInt32(txtSize.Text));
                    int selectedTypeId = GetSelectedPropertyTypeId(comboBoxPropertyTypes.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TypeID", Convert.ToInt32(selectedTypeId));
                    cmd.Parameters.AddWithValue("@Rent", Convert.ToDecimal(txtRent.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadPropertyTypesWithDataGrid(); // Refresh the DataGridView
        }
        
        
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Properties WHERE PropertyID = @PropertyID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", txtID.Text); // Assuming you have the ID of the selected property

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadPropertyTypesWithDataGrid(); // Refresh the DataGridView
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
                    dataGridViewProperties.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxPropertyTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

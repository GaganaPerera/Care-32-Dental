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
using System.Xml.Linq;

namespace Care_32_Dental
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\source\repos\Care 32 Dental\Care 32 Dental\Care32DentalClinic.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";

        private void patient_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = txtname.Text.Trim();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Name, RegNo FROM Patients WHERE Name LIKE @Name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + searchText + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    patientlist.DataSource = dt;
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Patients WHERE RegNumber=@RegNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNumber", txtregnumber.Text.Trim());
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Patient deleted successfully.");
                    else
                        MessageBox.Show("Patient not found.");
                    ResetFields();
                }
            }
        }
        private void ResetFields()
        {
            txtregnumber.Text = "";
            txtname.Text = "";
            txtage.Text = "";
            txtmobile.Text = "";
            dtpvisitdate.Value = DateTime.Now;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"UPDATE Patients SET Name=@Name, Age=@Age, Mobile=@Mobile, VisitDate=@VisitDate
                         WHERE RegNumber=@RegNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNumber", txtregnumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@VisitDate", dtpvisitdate.Value);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Patient updated successfully.");
                    else
                        MessageBox.Show("Patient not found.");
                    ResetFields();
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"INSERT INTO Patients (RegNumber, Name, Age, Mobile, VisitDate)
                         VALUES (@RegNumber, @Name, @Age, @Mobile, @VisitDate)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNumber", txtregnumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@VisitDate", dtpvisitdate.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient saved successfully.");
                    ResetFields();
                }
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}

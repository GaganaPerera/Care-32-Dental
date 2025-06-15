using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Care_32_Dental
{
    public partial class Doctor : Form
    {
        // Use your actual connection string here
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\OneDrive - esoft.lk\Documents\Care32DentalClinic.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Doctor()
        {
            InitializeComponent();
        }

        // Search doctor by ID or Name
        private void btnsearch_Click(object sender, EventArgs e)
        {
           
        }

        // Add new doctor
        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        // Update doctor
        private void btnupdate_Click(object sender, EventArgs e)
        {
           
        }

        // Delete doctor
        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID OR Name = @Name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", txtdocid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtdocname.Text.Trim());
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtdocid.Text = reader["DoctorID"].ToString();
                            txtdocname.Text = reader["Name"].ToString();
                            txtcontact.Text = reader["Mobile"].ToString();
                            txtemail.Text = reader["Email"].ToString();
                            cmbspecailization.Text = reader["Specialization"].ToString();
                            dtpDOB.Value = reader["RegisteredDate"] != DBNull.Value ? Convert.ToDateTime(reader["RegisteredDate"]) : DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Doctor not found.");
                        }
                    }
                }

            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Doctors WHERE DoctorID=@DoctorID OR Name=@Name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", txtdocid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtdocname.Text.Trim());
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Doctor deleted successfully.");
                    else
                        MessageBox.Show("Doctor not found.");
                }

                ResetFields();
            }
            }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"UPDATE Doctors SET Name=@Name, Mobile=@Mobile, Email=@Email, Specialization=@Specialization, RegisteredDate=@RegisteredDate
                                 WHERE DoctorID=@DoctorID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", txtdocid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtdocname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Specialization", cmbspecailization.Text.Trim());
                    cmd.Parameters.AddWithValue("@RegisteredDate", dtpDOB.Value);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Doctor updated successfully.");
                    else
                        MessageBox.Show("Doctor not found.");
                    ResetFields(); // Clear fields after update
                }
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"INSERT INTO Doctors (Name, Mobile, Email, Specialization, RegisteredDate)
                                 VALUES ( @Name, @Mobile, @Email, @Specialization, @RegisteredDate)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", txtdocid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtdocname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Specialization", cmbspecailization.Text.Trim());
                    cmd.Parameters.AddWithValue("@RegisteredDate", dtpDOB.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor added successfully.");
                    ResetFields(); 
                }
            }
        }
        
            private void ResetFields()
        {
            txtdocid.Text = "";
            txtdocname.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            cmbspecailization.SelectedIndex = -1; // Deselect any selection
            dtpDOB.Value = DateTime.Now; // Or set to a specific default date if needed
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            patient patientForm = new patient();
            patientForm.Show();
            this.Hide();
        }
    }

}


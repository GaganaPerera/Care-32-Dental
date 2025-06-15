using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Care_32_Dental
{
    public partial class login : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\OneDrive - esoft.lk\Documents\Care32DentalClinic.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public login()
        {
            InitializeComponent();
            btnlogin.Click += Btnlogin_Click;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = zeroitMetroTextbox1.Text.Trim();
            string password = zeroitMetroTextbox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordHash = ComputeSha256Hash(password);

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND passwordhash = @passwordhash";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwordhash", passwordHash);

                    conn.Open();
                    int userCount = (int)cmd.ExecuteScalar();
                    conn.Close();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Doctor mainForm = new Doctor();
                        mainForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LanguageApp2
{
    public partial class User : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\axund\OneDrive\Documents\Languagedb.mdf;Integrated Security=True;Connect Timeout=30");
        public User()
        {
            InitializeComponent();
        }

        private void User_Load_1(object sender, EventArgs e)
        {
            populate();
        }


        private void populate()
        {
            Con.Open();
            string query = "select * from UserTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            userDGV.DataSource = dataSet.Tables[0];
            Con.Close();
        }

        //ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userNameTable.Text) || string.IsNullOrWhiteSpace(userPasswordTable.Text) || string.IsNullOrWhiteSpace(userIDTable.Text))
                {
                    MessageBox.Show("Please fill in all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(userIDTable.Text, out int userID))
                    {
                        MessageBox.Show("Invalid User ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the user already exists with the given ID
                    if (IsUserExist(userID))
                    {
                        MessageBox.Show("User with the same ID already exists. Choose a different User ID.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO UserTable (userName, userID, userPassword) VALUES (@userName, @userID, @userPassword)", Con))
                    {
                        cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 255).Value = userNameTable.Text;
                        cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                        cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar, 255).Value = userPasswordTable.Text;

                        Con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                    populate();
                }
            }
        }

        private bool IsUserExist(int userID)
        {
            // Check if a user with the specified ID already exists in the database
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTable WHERE userID = @userID", Con))
            {
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                Con.Open();
                int count = (int)cmd.ExecuteScalar();
                Con.Close();

                return count > 0;
            }
        }

        private void userDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userIDTable.Text = userDGV.SelectedRows[0].Cells[0].Value.ToString();
            userNameTable.Text = userDGV.SelectedRows[0].Cells[1].Value.ToString();
            userPasswordTable.Text = userDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userIDTable.Text))
                {
                    MessageBox.Show("Enter The User ID");
                }
                else
                {
                    Con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "DELETE FROM UserTable WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userIDTable.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("User with the specified ID DOES NOT EXIST or has already been DELETED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    Con.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Not Deleted: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userNameTable.Text) || string.IsNullOrWhiteSpace(userPasswordTable.Text) || string.IsNullOrWhiteSpace(userIDTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Con.Open();
                    string query = "update UserTable set userName='" + userNameTable.Text + "',userPassword='" + userPasswordTable.Text + "' where userID=" + userIDTable.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Not Edited: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}

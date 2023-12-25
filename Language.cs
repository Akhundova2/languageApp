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

namespace LanguageApp2
{
    public partial class Language : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\axund\OneDrive\Documents\Languagedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Language()
        {
            InitializeComponent();
        }

        private void Language_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from LanguageTable";
            SqlDataAdapter languageAdapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(languageAdapter);
            var dataSet = new DataSet();
            languageAdapter.Fill(dataSet);
            languageDGV.DataSource = dataSet.Tables[0];
            Con.Close();
        }

        //ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(languageNameTable.Text) || string.IsNullOrWhiteSpace(languageIDTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(languageIDTable.Text, out int languageID))
                    {
                        MessageBox.Show("Invalid Language ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the language already exists with the given ID
                    if (IsLanguageExist(languageID))
                    {
                        MessageBox.Show("Language with the same ID already exists. Choose a different LANGUAGE ID.", "Duplicate Language ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand langCMD = new SqlCommand("INSERT INTO LanguageTable (languageName, languageID) VALUES (@languageName, @languageID)", Con))
                    {
                        langCMD.Parameters.Add("@languageName", SqlDbType.NVarChar, 255).Value = languageNameTable.Text;
                        langCMD.Parameters.Add("@languageID", SqlDbType.Int).Value = languageID;

                        Con.Open();
                        int rowsAffected = langCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Language successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add language.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Con.Close();
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

                }
            }
        }

        private bool IsLanguageExist(int languageID)
        {
            // Check if a language with the specified ID already exists in the database
            using (SqlCommand langCMD = new SqlCommand("SELECT COUNT(*) FROM LanguageTable WHERE languageID = @languageID", Con))
            {
                langCMD.Parameters.Add("@languageID", SqlDbType.Int).Value = languageID;

                Con.Open();
                int count = (int)langCMD.ExecuteScalar();
                Con.Close();

                return count > 0;
            }
        }

        private void languageDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            languageIDTable.Text = languageDGV.SelectedRows[0].Cells[0].Value.ToString();
            languageNameTable.Text = languageDGV.SelectedRows[0].Cells[1].Value.ToString();
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
                if (string.IsNullOrWhiteSpace(languageIDTable.Text))
                {
                    MessageBox.Show("Enter The Language ID");
                }
                else
                {
                    Con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "DELETE FROM LanguageTable WHERE LanguageID = @LanguageID";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@languageID", Convert.ToInt32(languageIDTable.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Language Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Language with the specified ID DOES NOT EXIST or has already been DELETED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Language Not Deleted: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        //EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(languageNameTable.Text) || string.IsNullOrWhiteSpace(languageIDTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE LanguageTable SET languageName = @languageName WHERE languageID = @languageID", Con))
                    {
                        cmd.Parameters.Add("@languageName", SqlDbType.NVarChar, 255).Value = languageNameTable.Text;
                        cmd.Parameters.Add("@languageID", SqlDbType.Int).Value = Convert.ToInt32(languageIDTable.Text);

                        Con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Language successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("No language with the specified ID found for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Language Not Edited: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();

                }
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


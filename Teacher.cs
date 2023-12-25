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

    public partial class Teacher : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\axund\OneDrive\Documents\Languagedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Teacher()
        {
            InitializeComponent();
        }

        private void fillDepartment()
        {
            Con.Open();
            SqlCommand teacherCMD = new SqlCommand("select languageName from LanguageTable", Con);
            SqlDataReader langDataReader;
            langDataReader = teacherCMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("languageName", typeof(string));
            dt.Load(langDataReader);
            teacherDepartment.ValueMember = "languageName";
            teacherDepartment.DataSource = dt;
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from TeacherTable";
            SqlDataAdapter teacherAdapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(teacherAdapter);
            var dataSet = new DataSet();
            teacherAdapter.Fill(dataSet);
            TeacherDGV.DataSource = dataSet.Tables[0];
            Con.Close();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            fillDepartment();
            populate();
        }

        //ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(teacherNameTable.Text) || string.IsNullOrWhiteSpace(teacherIDTable.Text) || string.IsNullOrWhiteSpace(teacherPhoneTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(teacherIDTable.Text, out int teacherID))
                    {
                        MessageBox.Show("Invalid Teacher ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the teacher already exists with the given ID
                    if (IsTeacherExist(teacherID))
                    {
                        MessageBox.Show("Teacher with the same ID already exists. Choose a different Teacher ID.", "Duplicate Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand teacherCMD = new SqlCommand("INSERT INTO TeacherTable (teacherName, teacherID, teacherGender, teacherDepartment, teacherPhone) VALUES (@teacherName, @teacherID, @teacherGender, @teacherDepartment, @teacherPhone)", Con))
                    {
                        teacherCMD.Parameters.Add("@teacherName", SqlDbType.NVarChar, 255).Value = teacherNameTable.Text;
                        teacherCMD.Parameters.Add("@teacherID", SqlDbType.Int).Value = teacherID;
                        teacherCMD.Parameters.Add("@teacherGender", SqlDbType.NVarChar, 255).Value = teacherGender.Text;
                        teacherCMD.Parameters.Add("@teacherDepartment", SqlDbType.NVarChar, 255).Value = teacherDepartment.Text;
                        teacherCMD.Parameters.Add("@teacherPhone", SqlDbType.NVarChar, 255).Value = teacherPhoneTable.Text;

                        Con.Open();
                        int rowsAffected = teacherCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool IsTeacherExist(int teacherID)
        {
            // Check if a teacher with the specified ID already exists in the database
            using (SqlCommand teacherCMD = new SqlCommand("SELECT COUNT(*) FROM TeacherTable WHERE teacherID = @teacherID", Con))
            {
                teacherCMD.Parameters.Add("@teacherID", SqlDbType.Int).Value = teacherID;

                Con.Open();
                int count = (int)teacherCMD.ExecuteScalar();
                Con.Close();

                return count > 0;
            }
        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherIDTable.Text = TeacherDGV.SelectedRows[0].Cells[0].Value.ToString();
            teacherNameTable.Text = TeacherDGV.SelectedRows[0].Cells[1].Value.ToString();
            teacherGender.SelectedItem = TeacherDGV.SelectedRows[0].Cells[2].Value.ToString();
            teacherPhoneTable.Text = TeacherDGV.SelectedRows[0].Cells[3].Value.ToString();
            teacherDepartment.SelectedItem = TeacherDGV.SelectedRows[0].Cells[4].Value.ToString();
        }


        //EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(teacherNameTable.Text) || string.IsNullOrWhiteSpace(teacherIDTable.Text) || string.IsNullOrWhiteSpace(teacherPhoneTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlCommand teacherCMD = new SqlCommand("UPDATE TeacherTable SET teacherName = @teacherName, teacherGender = @teacherGender, teacherDepartment = @teacherDepartment, teacherPhone = @teacherPhone WHERE teacherID = @teacherID", Con))
                    {
                        teacherCMD.Parameters.Add("@teacherName", SqlDbType.NVarChar, 255).Value = teacherNameTable.Text;
                        teacherCMD.Parameters.Add("@teacherID", SqlDbType.Int).Value = Convert.ToInt32(teacherIDTable.Text);
                        teacherCMD.Parameters.Add("@teacherGender", SqlDbType.NVarChar, 255).Value = teacherGender.Text;
                        teacherCMD.Parameters.Add("@teacherDepartment", SqlDbType.NVarChar, 255).Value = teacherDepartment.Text;
                        teacherCMD.Parameters.Add("@teacherPhone", SqlDbType.NVarChar, 255).Value = teacherPhoneTable.Text;

                        Con.Open();
                        int rowsAffected = teacherCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("No teacher with the specified ID found for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Teacher Not Edited: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        //DELETE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(teacherIDTable.Text))
                {
                    MessageBox.Show("Enter The Teacher ID");
                }
                else
                {
                    Con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "DELETE FROM TeacherTable WHERE teacherID = @teacherID";
                    using (SqlCommand teacherCMD = new SqlCommand(query, Con))
                    {
                        teacherCMD.Parameters.AddWithValue("@teacherID", Convert.ToInt32(teacherIDTable.Text));
                        int rowsAffected = teacherCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Teacher with the specified ID DOES NOT EXIST or has already been DELETED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Teacher Not Deleted: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

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
    public partial class Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\axund\OneDrive\Documents\Languagedb.mdf;Integrated Security=True;Connect Timeout=30");

        public Student()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from StudentTable";
            SqlDataAdapter studentAdapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(studentAdapter);
            var dataSet = new DataSet();
            studentAdapter.Fill(dataSet);
            studentDGV.DataSource = dataSet.Tables[0];
            Con.Close();
        }

        //ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(studentNameTable.Text) || string.IsNullOrWhiteSpace(studentIDTable.Text) || string.IsNullOrWhiteSpace(studentPhoneTable.Text)
                    || string.IsNullOrWhiteSpace(studentFeeTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(studentIDTable.Text, out int studentID))
                    {
                        MessageBox.Show("Invalid Student ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the user already exists with the given ID
                    if (IsStudentExist(studentID))
                    {
                        MessageBox.Show("Student with the same ID already exists. Choose a different User ID.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand studentCMD = new SqlCommand("INSERT INTO StudentTable (studentName, studentID, studentFees, studentPhone, studentGender) VALUES (@studentName, @studentID, @studentFees, @studentPhone, @studentGender)", Con))
                    {
                        studentCMD.Parameters.Add("@studentName", SqlDbType.NVarChar, 255).Value = studentNameTable.Text;
                        studentCMD.Parameters.Add("@studentID", SqlDbType.Int).Value = studentID;
                        studentCMD.Parameters.Add("@studentFees", SqlDbType.NVarChar, 255).Value = studentFeeTable.Text;
                        studentCMD.Parameters.Add("@studentPhone", SqlDbType.NVarChar, 255).Value = studentPhoneTable.Text;
                        studentCMD.Parameters.Add("@studentGender", SqlDbType.NVarChar, 255).Value = studentGender.Text;

                        Con.Open();
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool IsStudentExist(int studentID)
        {
            // Check if a student with the specified ID already exists in the database
            using (SqlCommand studentCMD = new SqlCommand("SELECT COUNT(*) FROM StudentTable WHERE StudentID = @StudentID", Con))
            {
                studentCMD.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;

                Con.Open();
                int count = (int)studentCMD.ExecuteScalar();
                Con.Close();

                return count > 0;
            }
        }
        private void studentDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            studentIDTable.Text = studentDGV.SelectedRows[0].Cells[0].Value.ToString();
            studentNameTable.Text = studentDGV.SelectedRows[0].Cells[1].Value.ToString();
            studentGender.SelectedItem = studentDGV.SelectedRows[0].Cells[2].Value.ToString();
            studentPhoneTable.Text = studentDGV.SelectedRows[0].Cells[3].Value.ToString();
            studentFeeTable.Text = studentDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        //EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(studentNameTable.Text) || string.IsNullOrWhiteSpace(studentIDTable.Text) || string.IsNullOrWhiteSpace(studentPhoneTable.Text)
                    || string.IsNullOrWhiteSpace(studentFeeTable.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlCommand studentCMD = new SqlCommand("UPDATE StudentTable SET studentName = @StudentName, studentGender = @StudentGender, studentPhone = @StudentPhone, studentFees = @StudentFees WHERE studentID = @StudentID", Con))
                    {
                        studentCMD.Parameters.Add("@StudentName", SqlDbType.NVarChar, 255).Value = studentNameTable.Text;
                        studentCMD.Parameters.Add("@StudentID", SqlDbType.Int).Value = Convert.ToInt32(studentIDTable.Text);
                        studentCMD.Parameters.Add("@StudentGender", SqlDbType.NVarChar, 255).Value = studentGender.Text;
                        studentCMD.Parameters.Add("@StudentFees", SqlDbType.NVarChar, 255).Value = studentFeeTable.Text;
                        studentCMD.Parameters.Add("@StudentPhone", SqlDbType.NVarChar, 255).Value = studentPhoneTable.Text;

                        Con.Open();
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("No Student with the specified ID found for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Student Not Edited: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(studentIDTable.Text))
                {
                    MessageBox.Show("Enter The Student ID");
                }
                else
                {
                    Con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "DELETE FROM StudentTable WHERE studentID = @StudentID";
                    using (SqlCommand studentCMD = new SqlCommand(query, Con))
                    {
                        studentCMD.Parameters.AddWithValue("@StudentID", Convert.ToInt32(studentIDTable.Text));
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Student with the specified ID DOES NOT EXIST or has already been DELETED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Student Not Deleted: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

    }
}

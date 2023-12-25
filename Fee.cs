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
    public partial class Fee : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\axund\OneDrive\Documents\Languagedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Fee()
        {
            InitializeComponent();
        }
        private void fillStudentName()
        {
            Con.Open();
            SqlCommand studentCMD = new SqlCommand("select StudentName from StudentTable", Con);
            SqlDataReader studentNameDataReader;
            studentNameDataReader = studentCMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentName", typeof(string));
            dt.Load(studentNameDataReader);
            feeStudentNameCB.ValueMember = "StudentName";
            feeStudentNameCB.DataSource = dt;
            Con.Close();
        }
        private void fillStudentID()
        {
            Con.Open();
            SqlCommand studentIDCMD = new SqlCommand("select StudentID from StudentTable", Con);
            SqlDataReader studentIDDataReader;
            studentIDDataReader = studentIDCMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentID", typeof(string));
            dt.Load(studentIDDataReader);
            feeStudentIDCB.ValueMember = "StudentID";
            feeStudentIDCB.DataSource = dt;
            Con.Close();
        }
        private void fillAmount()
        {
            Con.Open();
            SqlCommand studentCMD = new SqlCommand("select StudentFees from StudentTable", Con);
            SqlDataReader feeAmountDataReader;
            feeAmountDataReader = studentCMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentFees", typeof(string));
            dt.Load(feeAmountDataReader);
            feeAmountCB.ValueMember = "StudentFees";
            feeAmountCB.DataSource = dt;
            Con.Close();
        }

        private void Fee_Load(object sender, EventArgs e)
        {
            fillStudentName();
            fillStudentID();
            fillAmount();
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from FeeTable";
            SqlDataAdapter feeAdapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(feeAdapter);
            var dataSet = new DataSet();
            feeAdapter.Fill(dataSet);
            feeDGV.DataSource = dataSet.Tables[0];
            Con.Close();
        }

        //PAY BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(feeNumTable.Text))
                {
                    MessageBox.Show("Please add a Payment Number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(feeStudentIDCB.Text, out int StudentID))
                    {
                        MessageBox.Show("Invalid Student ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the user already exists with the given ID
                    if (IsPaymentAlreadyAdded(StudentID))
                    {
                        MessageBox.Show("Payment with the same ID already exists. Choose a different Student ID.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand studentCMD = new SqlCommand("INSERT INTO FeeTable (StudentName, StudentID, feesNum, Amount) VALUES (@feeStudentNameCB, @feeStudentIDCB, @feeNumTable, @feeAmountCB)", Con))
                    {
                        studentCMD.Parameters.Add("@feeStudentNameCB", SqlDbType.NVarChar, 255).Value = feeStudentNameCB.Text;
                        studentCMD.Parameters.Add("@feeStudentIDCB", SqlDbType.Int).Value = StudentID;
                        studentCMD.Parameters.Add("@feeNumTable", SqlDbType.NVarChar, 255).Value = feeNumTable.Text;
                        studentCMD.Parameters.Add("@feeAmountCB", SqlDbType.NVarChar, 255).Value = feeAmountCB.Text;

                        Con.Open();
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool IsPaymentAlreadyAdded(int StudentID)
        {
            // Check if a payment with the specified ID already exists in the database
            using (SqlCommand feeCMD = new SqlCommand("SELECT COUNT(*) FROM FeeTable WHERE StudentID = @StudentID", Con))
            {
                feeCMD.Parameters.Add("@StudentID", SqlDbType.Int).Value = StudentID;

                Con.Open();
                int count = (int)feeCMD.ExecuteScalar();
                Con.Close();

                return count > 0;
            }
        }
        private void feeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            feeNumTable.Text = feeDGV.SelectedRows[0].Cells[0].Value.ToString();

            feeStudentNameCB.Text = feeDGV.SelectedRows[0].Cells[1].Value.ToString();
            feeStudentIDCB.Text = feeDGV.SelectedRows[0].Cells[2].Value.ToString();
            feeAmountCB.Text = feeDGV.SelectedRows[0].Cells[3].Value.ToString();
        }


        //EDIT BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(feeNumTable.Text))
                {
                    MessageBox.Show("Please add a Payment Number.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (SqlCommand studentCMD = new SqlCommand("UPDATE FeeTable SET StudentName = @feeStudentNameCB, feesNum = @feeNumTable, Amount = @feeAmountCB WHERE StudentID = @feeStudentIDCB", Con))
                    {
                        studentCMD.Parameters.Add("@feeStudentNameCB", SqlDbType.NVarChar, 255).Value = feeStudentNameCB.Text;
                        studentCMD.Parameters.Add("@feeStudentIDCB", SqlDbType.Int).Value = Convert.ToInt32(feeStudentIDCB.Text);
                        studentCMD.Parameters.Add("@feeNumTable", SqlDbType.NVarChar, 255).Value = feeNumTable.Text;
                        studentCMD.Parameters.Add("@feeAmountCB", SqlDbType.NVarChar, 255).Value = feeAmountCB.Text;

                        Con.Open();
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("No Payment with the specified ID found for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(feeStudentIDCB.Text))
                {
                    MessageBox.Show("Enter The Student ID");
                }
                else
                {
                    Con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "DELETE FROM FeeTable WHERE StudentID = @feeStudentIDCB";
                    using (SqlCommand studentCMD = new SqlCommand(query, Con))
                    {
                        studentCMD.Parameters.AddWithValue("@feeStudentIDCB", Convert.ToInt32(feeStudentIDCB.Text));
                        int rowsAffected = studentCMD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Paymnet Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Con.Close();
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("Paymnet with the specified ID DOES NOT EXIST or has already been DELETED", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Payment Not Deleted: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        
    }

}

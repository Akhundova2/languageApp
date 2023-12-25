namespace LanguageApp2
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            studentIDTable = new TextBox();
            label4 = new Label();
            studentNameTable = new TextBox();
            label5 = new Label();
            studentGender = new ComboBox();
            label6 = new Label();
            studentPhoneTable = new TextBox();
            label7 = new Label();
            studentFeeTable = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            studentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(1041, 69);
            label1.TabIndex = 1;
            label1.Text = "STUDENTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(1006, -1);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 9;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(0, 547);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 14);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(27, 19);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // studentIDTable
            // 
            studentIDTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDTable.Location = new Point(123, 89);
            studentIDTable.Name = "studentIDTable";
            studentIDTable.Size = new Size(125, 27);
            studentIDTable.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(23, 138);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 13;
            label4.Text = "NAME";
            // 
            // studentNameTable
            // 
            studentNameTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentNameTable.Location = new Point(123, 130);
            studentNameTable.Name = "studentNameTable";
            studentNameTable.Size = new Size(125, 27);
            studentNameTable.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(23, 178);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 15;
            label5.Text = "GENDER";
            // 
            // studentGender
            // 
            studentGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentGender.FormattingEnabled = true;
            studentGender.Items.AddRange(new object[] { "Male", "Female" });
            studentGender.Location = new Point(123, 169);
            studentGender.Name = "studentGender";
            studentGender.Size = new Size(125, 28);
            studentGender.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(23, 220);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 17;
            label6.Text = "PHONE";
            // 
            // studentPhoneTable
            // 
            studentPhoneTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentPhoneTable.Location = new Point(123, 212);
            studentPhoneTable.Name = "studentPhoneTable";
            studentPhoneTable.Size = new Size(125, 27);
            studentPhoneTable.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(23, 264);
            label7.Name = "label7";
            label7.Size = new Size(39, 19);
            label7.TabIndex = 19;
            label7.Text = "FEE";
            // 
            // studentFeeTable
            // 
            studentFeeTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentFeeTable.Location = new Point(123, 256);
            studentFeeTable.Name = "studentFeeTable";
            studentFeeTable.Size = new Size(125, 27);
            studentFeeTable.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 312);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 22;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(106, 312);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 23;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(189, 312);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 24;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(90, 364);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 25;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(598, 80);
            label8.Name = "label8";
            label8.Size = new Size(186, 23);
            label8.TabIndex = 26;
            label8.Text = "STUDENTS LIST";
            // 
            // studentDGV
            // 
            studentDGV.AllowUserToAddRows = false;
            studentDGV.AllowUserToDeleteRows = false;
            studentDGV.AllowUserToResizeColumns = false;
            studentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            studentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentDGV.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            studentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentDGV.ColumnHeadersHeight = 30;
            studentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            studentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            studentDGV.GridColor = Color.FromArgb(231, 229, 255);
            studentDGV.Location = new Point(329, 106);
            studentDGV.Name = "studentDGV";
            studentDGV.ReadOnly = true;
            studentDGV.RowHeadersVisible = false;
            studentDGV.RowHeadersWidth = 51;
            studentDGV.Size = new Size(690, 426);
            studentDGV.TabIndex = 66;
            studentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            studentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            studentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            studentDGV.ThemeStyle.BackColor = Color.White;
            studentDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            studentDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            studentDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            studentDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            studentDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            studentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            studentDGV.ThemeStyle.HeaderStyle.Height = 30;
            studentDGV.ThemeStyle.ReadOnly = true;
            studentDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            studentDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            studentDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            studentDGV.ThemeStyle.RowsStyle.Height = 29;
            studentDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            studentDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            studentDGV.CellContentClick += studentDGV_CellContentClick_1;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 564);
            Controls.Add(studentDGV);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(studentFeeTable);
            Controls.Add(label7);
            Controls.Add(studentPhoneTable);
            Controls.Add(label6);
            Controls.Add(studentGender);
            Controls.Add(label5);
            Controls.Add(studentNameTable);
            Controls.Add(label4);
            Controls.Add(studentIDTable);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)studentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private TextBox studentIDTable;
        private Label label4;
        private TextBox studentNameTable;
        private Label label5;
        private ComboBox studentGender;
        private Label label6;
        private TextBox studentPhoneTable;
        private Label label7;
        private TextBox studentFeeTable;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView studentDGV;
    }
}
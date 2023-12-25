namespace LanguageApp2
{
    partial class Teacher
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            teacherPhoneTable = new TextBox();
            label6 = new Label();
            teacherGender = new ComboBox();
            label5 = new Label();
            teacherNameTable = new TextBox();
            label4 = new Label();
            teacherIDTable = new TextBox();
            label3 = new Label();
            label8 = new Label();
            TeacherDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            teacherDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(1041, 69);
            label1.TabIndex = 2;
            label1.Text = "TEACHERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(1006, -1);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 10;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(98, 368);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 39;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(197, 316);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 38;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(114, 316);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 37;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 316);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 36;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // teacherPhoneTable
            // 
            teacherPhoneTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherPhoneTable.Location = new Point(155, 216);
            teacherPhoneTable.Name = "teacherPhoneTable";
            teacherPhoneTable.Size = new Size(125, 27);
            teacherPhoneTable.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(12, 224);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 32;
            label6.Text = "PHONE";
            // 
            // teacherGender
            // 
            teacherGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherGender.FormattingEnabled = true;
            teacherGender.Items.AddRange(new object[] { "Male", "Female" });
            teacherGender.Location = new Point(155, 178);
            teacherGender.Name = "teacherGender";
            teacherGender.Size = new Size(125, 28);
            teacherGender.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 30;
            label5.Text = "GENDER";
            // 
            // teacherNameTable
            // 
            teacherNameTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherNameTable.Location = new Point(155, 142);
            teacherNameTable.Name = "teacherNameTable";
            teacherNameTable.Size = new Size(125, 27);
            teacherNameTable.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 28;
            label4.Text = "NAME";
            // 
            // teacherIDTable
            // 
            teacherIDTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherIDTable.Location = new Point(155, 105);
            teacherIDTable.Name = "teacherIDTable";
            teacherIDTable.Size = new Size(125, 27);
            teacherIDTable.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(27, 19);
            label3.TabIndex = 26;
            label3.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(618, 85);
            label8.Name = "label8";
            label8.Size = new Size(186, 23);
            label8.TabIndex = 41;
            label8.Text = "TEACHERS LIST";
            // 
            // TeacherDGV
            // 
            TeacherDGV.AllowUserToAddRows = false;
            TeacherDGV.AllowUserToDeleteRows = false;
            TeacherDGV.AllowUserToResizeColumns = false;
            TeacherDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            TeacherDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TeacherDGV.BorderStyle = BorderStyle.FixedSingle;
            TeacherDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TeacherDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TeacherDGV.ColumnHeadersHeight = 30;
            TeacherDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TeacherDGV.DefaultCellStyle = dataGridViewCellStyle3;
            TeacherDGV.GridColor = Color.FromArgb(231, 229, 255);
            TeacherDGV.Location = new Point(338, 111);
            TeacherDGV.Name = "TeacherDGV";
            TeacherDGV.ReadOnly = true;
            TeacherDGV.RowHeadersVisible = false;
            TeacherDGV.RowHeadersWidth = 51;
            TeacherDGV.RowTemplate.Height = 25;
            TeacherDGV.Size = new Size(690, 426);
            TeacherDGV.TabIndex = 67;
            TeacherDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            TeacherDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            TeacherDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            TeacherDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            TeacherDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            TeacherDGV.ThemeStyle.BackColor = Color.White;
            TeacherDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            TeacherDGV.ThemeStyle.HeaderStyle.BackColor = Color.Crimson;
            TeacherDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            TeacherDGV.ThemeStyle.HeaderStyle.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            TeacherDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TeacherDGV.ThemeStyle.HeaderStyle.Height = 30;
            TeacherDGV.ThemeStyle.ReadOnly = true;
            TeacherDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            TeacherDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TeacherDGV.ThemeStyle.RowsStyle.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeacherDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            TeacherDGV.ThemeStyle.RowsStyle.Height = 25;
            TeacherDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            TeacherDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            TeacherDGV.CellContentClick += TeacherDGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(12, 261);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 68;
            label7.Text = "DEPARTMENT";
            // 
            // teacherDepartment
            // 
            teacherDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherDepartment.FormattingEnabled = true;
            teacherDepartment.Items.AddRange(new object[] { "Male", "Female" });
            teacherDepartment.Location = new Point(155, 252);
            teacherDepartment.Name = "teacherDepartment";
            teacherDepartment.Size = new Size(125, 28);
            teacherDepartment.TabIndex = 69;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 564);
            Controls.Add(teacherDepartment);
            Controls.Add(label7);
            Controls.Add(TeacherDGV);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(teacherPhoneTable);
            Controls.Add(label6);
            Controls.Add(teacherGender);
            Controls.Add(label5);
            Controls.Add(teacherNameTable);
            Controls.Add(label4);
            Controls.Add(teacherIDTable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            Load += Teacher_Load;
            ((System.ComponentModel.ISupportInitialize)TeacherDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox teacherPhoneTable;
        private Label label6;
        private ComboBox teacherGender;
        private Label label5;
        private TextBox teacherNameTable;
        private Label label4;
        private TextBox teacherIDTable;
        private Label label3;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView TeacherDGV;
        private Label label7;
        private ComboBox teacherDepartment;
    }
}
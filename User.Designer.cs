namespace LanguageApp2
{
    partial class User
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
            label5 = new Label();
            userIDTable = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            userPasswordTable = new TextBox();
            label6 = new Label();
            userNameTable = new TextBox();
            label4 = new Label();
            userDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)userDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(1044, 69);
            label1.TabIndex = 4;
            label1.Text = "USERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(1007, -1);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 12;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(31, 193);
            label5.Name = "label5";
            label5.Size = new Size(27, 19);
            label5.TabIndex = 65;
            label5.Text = "ID";
            // 
            // userIDTable
            // 
            userIDTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userIDTable.Location = new Point(172, 189);
            userIDTable.Name = "userIDTable";
            userIDTable.Size = new Size(125, 27);
            userIDTable.TabIndex = 64;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(98, 379);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 63;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(197, 327);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 62;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(114, 327);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 61;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 327);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 60;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userPasswordTable
            // 
            userPasswordTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userPasswordTable.Location = new Point(172, 227);
            userPasswordTable.Name = "userPasswordTable";
            userPasswordTable.Size = new Size(125, 27);
            userPasswordTable.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(31, 235);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 58;
            label6.Text = "PASSWORD";
            // 
            // userNameTable
            // 
            userNameTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameTable.Location = new Point(172, 145);
            userNameTable.Name = "userNameTable";
            userNameTable.Size = new Size(125, 27);
            userNameTable.TabIndex = 57;
            userNameTable.Text = "\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(31, 153);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 56;
            label4.Text = "NAME";
            // 
            // userDGV
            // 
            userDGV.AllowUserToAddRows = false;
            userDGV.AllowUserToDeleteRows = false;
            userDGV.AllowUserToResizeColumns = false;
            userDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            userDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userDGV.BorderStyle = BorderStyle.FixedSingle;
            userDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userDGV.ColumnHeadersHeight = 30;
            userDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userDGV.DefaultCellStyle = dataGridViewCellStyle3;
            userDGV.GridColor = Color.FromArgb(231, 229, 255);
            userDGV.Location = new Point(338, 104);
            userDGV.Name = "userDGV";
            userDGV.ReadOnly = true;
            userDGV.RowHeadersVisible = false;
            userDGV.RowHeadersWidth = 51;
            userDGV.RowTemplate.Height = 25;
            userDGV.Size = new Size(690, 426);
            userDGV.TabIndex = 66;
            userDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            userDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            userDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            userDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            userDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            userDGV.ThemeStyle.BackColor = Color.White;
            userDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            userDGV.ThemeStyle.HeaderStyle.BackColor = Color.Crimson;
            userDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            userDGV.ThemeStyle.HeaderStyle.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            userDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            userDGV.ThemeStyle.HeaderStyle.Height = 30;
            userDGV.ThemeStyle.ReadOnly = true;
            userDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            userDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDGV.ThemeStyle.RowsStyle.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            userDGV.ThemeStyle.RowsStyle.Height = 25;
            userDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            userDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            userDGV.CellContentClick += userDGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(617, 78);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 67;
            label8.Text = "USERS LIST";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 564);
            Controls.Add(label8);
            Controls.Add(userDGV);
            Controls.Add(label5);
            Controls.Add(userIDTable);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(userPasswordTable);
            Controls.Add(label6);
            Controls.Add(userNameTable);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load_1;
            ((System.ComponentModel.ISupportInitialize)userDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox userIDTable;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox userPasswordTable;
        private Label label6;
        private TextBox userNameTable;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView userDGV;
        private Label label8;
    }
}
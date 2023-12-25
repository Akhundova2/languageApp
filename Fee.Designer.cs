namespace LanguageApp2
{
    partial class Fee
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
            label6 = new Label();
            label4 = new Label();
            feeNumTable = new TextBox();
            label3 = new Label();
            label5 = new Label();
            feeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label8 = new Label();
            feeStudentIDCB = new ComboBox();
            feeStudentNameCB = new ComboBox();
            feeAmountCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)feeDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1044, 69);
            label1.TabIndex = 3;
            label1.Text = "FEE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(1007, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 11;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(108, 380);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 51;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(207, 328);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 50;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(124, 328);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 49;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 328);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 48;
            button1.Text = "PAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(21, 236);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 46;
            label6.Text = "AMOUNT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(21, 154);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 42;
            label4.Text = "STUDENT NAME";
            // 
            // feeNumTable
            // 
            feeNumTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feeNumTable.Location = new Point(182, 105);
            feeNumTable.Name = "feeNumTable";
            feeNumTable.Size = new Size(125, 27);
            feeNumTable.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(21, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 40;
            label3.Text = "NUM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(21, 198);
            label5.Name = "label5";
            label5.Size = new Size(114, 19);
            label5.TabIndex = 53;
            label5.Text = "STUDENT ID";
            // 
            // feeDGV
            // 
            feeDGV.AllowUserToAddRows = false;
            feeDGV.AllowUserToDeleteRows = false;
            feeDGV.AllowUserToResizeColumns = false;
            feeDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            feeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            feeDGV.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            feeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            feeDGV.ColumnHeadersHeight = 30;
            feeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            feeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            feeDGV.GridColor = Color.FromArgb(231, 229, 255);
            feeDGV.Location = new Point(338, 113);
            feeDGV.Name = "feeDGV";
            feeDGV.ReadOnly = true;
            feeDGV.RowHeadersVisible = false;
            feeDGV.RowHeadersWidth = 51;
            feeDGV.Size = new Size(690, 426);
            feeDGV.TabIndex = 66;
            feeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            feeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            feeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            feeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            feeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            feeDGV.ThemeStyle.BackColor = Color.White;
            feeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            feeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            feeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            feeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            feeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            feeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            feeDGV.ThemeStyle.HeaderStyle.Height = 30;
            feeDGV.ThemeStyle.ReadOnly = true;
            feeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            feeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            feeDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            feeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            feeDGV.ThemeStyle.RowsStyle.Height = 29;
            feeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            feeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            feeDGV.CellContentClick += feeDGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(607, 79);
            label8.Name = "label8";
            label8.Size = new Size(195, 23);
            label8.TabIndex = 55;
            label8.Text = "PAYMENTS LIST";
            // 
            // feeStudentIDCB
            // 
            feeStudentIDCB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feeStudentIDCB.FormattingEnabled = true;
            feeStudentIDCB.Items.AddRange(new object[] { "Male", "Female" });
            feeStudentIDCB.Location = new Point(182, 189);
            feeStudentIDCB.Name = "feeStudentIDCB";
            feeStudentIDCB.Size = new Size(125, 28);
            feeStudentIDCB.TabIndex = 56;
            // 
            // feeStudentNameCB
            // 
            feeStudentNameCB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feeStudentNameCB.FormattingEnabled = true;
            feeStudentNameCB.Items.AddRange(new object[] { "Male", "Female" });
            feeStudentNameCB.Location = new Point(182, 145);
            feeStudentNameCB.Name = "feeStudentNameCB";
            feeStudentNameCB.Size = new Size(125, 28);
            feeStudentNameCB.TabIndex = 58;
            // 
            // feeAmountCB
            // 
            feeAmountCB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feeAmountCB.FormattingEnabled = true;
            feeAmountCB.Items.AddRange(new object[] { "Male", "Female" });
            feeAmountCB.Location = new Point(182, 235);
            feeAmountCB.Name = "feeAmountCB";
            feeAmountCB.Size = new Size(125, 28);
            feeAmountCB.TabIndex = 59;
            // 
            // Fee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 564);
            Controls.Add(feeAmountCB);
            Controls.Add(feeStudentNameCB);
            Controls.Add(feeStudentIDCB);
            Controls.Add(label8);
            Controls.Add(feeDGV);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(feeNumTable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fee";
            Load += Fee_Load;
            ((System.ComponentModel.ISupportInitialize)feeDGV).EndInit();
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
        private Label label6;
        private Label label4;
        private TextBox feeNumTable;
        private Label label3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView feeDGV;
        private Label label8;
        private ComboBox feeStudentIDCB;
        private ComboBox feeStudentNameCB;
        private ComboBox feeAmountCB;
    }
}
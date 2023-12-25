
namespace LanguageApp2
{
    partial class Language
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
            languageIDTable = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            languageNameTable = new TextBox();
            label4 = new Label();
            languageDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)languageDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(1043, 69);
            label1.TabIndex = 4;
            label1.Text = "LANGUAGES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(1007, -1);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 13;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(19, 170);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 75;
            label5.Text = "LANGUAGE ID";
            // 
            // languageIDTable
            // 
            languageIDTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            languageIDTable.Location = new Point(190, 162);
            languageIDTable.Name = "languageIDTable";
            languageIDTable.Size = new Size(125, 27);
            languageIDTable.TabIndex = 74;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(116, 352);
            button4.Name = "button4";
            button4.Size = new Size(110, 29);
            button4.TabIndex = 73;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(215, 300);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 72;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(132, 300);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 71;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 300);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 70;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // languageNameTable
            // 
            languageNameTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            languageNameTable.Location = new Point(190, 118);
            languageNameTable.Name = "languageNameTable";
            languageNameTable.Size = new Size(125, 27);
            languageNameTable.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MoeumT R", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(19, 126);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 66;
            label4.Text = "LANGUAGE NAME";
            // 
            // languageDGV
            // 
            languageDGV.AllowUserToAddRows = false;
            languageDGV.AllowUserToDeleteRows = false;
            languageDGV.AllowUserToResizeColumns = false;
            languageDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            languageDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            languageDGV.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            languageDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            languageDGV.ColumnHeadersHeight = 30;
            languageDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            languageDGV.DefaultCellStyle = dataGridViewCellStyle3;
            languageDGV.GridColor = Color.FromArgb(231, 229, 255);
            languageDGV.Location = new Point(338, 106);
            languageDGV.Name = "languageDGV";
            languageDGV.ReadOnly = true;
            languageDGV.RowHeadersVisible = false;
            languageDGV.RowHeadersWidth = 51;
            languageDGV.Size = new Size(690, 426);
            languageDGV.TabIndex = 76;
            languageDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            languageDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            languageDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            languageDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            languageDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            languageDGV.ThemeStyle.BackColor = Color.White;
            languageDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            languageDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            languageDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            languageDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            languageDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            languageDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            languageDGV.ThemeStyle.HeaderStyle.Height = 30;
            languageDGV.ThemeStyle.ReadOnly = true;
            languageDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            languageDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            languageDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            languageDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            languageDGV.ThemeStyle.RowsStyle.Height = 29;
            languageDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            languageDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            languageDGV.CellContentClick += languageDGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(606, 80);
            label8.Name = "label8";
            label8.Size = new Size(209, 23);
            label8.TabIndex = 77;
            label8.Text = "LANGUAGES LIST";
            // 
            // Language
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 564);
            Controls.Add(label8);
            Controls.Add(languageDGV);
            Controls.Add(label5);
            Controls.Add(languageIDTable);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(languageNameTable);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Language";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Language";
            Load += Language_Load;
            ((System.ComponentModel.ISupportInitialize)languageDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox languageIDTable;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox languageNameTable;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView languageDGV;
        private Label label8;
    }
}
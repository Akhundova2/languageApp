
namespace LanguageApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            loginPasswordTable = new TextBox();
            loginUsernameTable = new TextBox();
            button1 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            enterUsernameLabel = new Label();
            enterPasswordLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(434, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Purple;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 66);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HYMyeongJo-Extra", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(127, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginPasswordTable
            // 
            loginPasswordTable.BackColor = Color.LavenderBlush;
            loginPasswordTable.Font = new Font("Calisto MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPasswordTable.ForeColor = Color.Blue;
            loginPasswordTable.Location = new Point(108, 267);
            loginPasswordTable.Name = "loginPasswordTable";
            loginPasswordTable.Size = new Size(176, 28);
            loginPasswordTable.TabIndex = 2;
            loginPasswordTable.TextAlign = HorizontalAlignment.Center;
            // 
            // loginUsernameTable
            // 
            loginUsernameTable.BackColor = Color.LavenderBlush;
            loginUsernameTable.Font = new Font("Calisto MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUsernameTable.ForeColor = Color.Blue;
            loginUsernameTable.Location = new Point(108, 203);
            loginUsernameTable.Name = "loginUsernameTable";
            loginUsernameTable.Size = new Size(176, 28);
            loginUsernameTable.TabIndex = 3;
            loginUsernameTable.TextAlign = HorizontalAlignment.Center;
            loginUsernameTable.TextChanged += loginUsernameTable_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(108, 328);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(108, 382);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "clear";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Navy;
            checkBox1.Location = new Point(210, 363);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterUsernameLabel.Location = new Point(108, 183);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(136, 17);
            enterUsernameLabel.TabIndex = 5;
            enterUsernameLabel.Text = "Enter USERNAME";
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize = true;
            enterPasswordLabel.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterPasswordLabel.Location = new Point(108, 247);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(135, 17);
            enterPasswordLabel.TabIndex = 6;
            enterPasswordLabel.Text = "Enter PASSWORD";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // label3
            // 
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(260, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 40);
            label3.TabIndex = 13;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(enterPasswordLabel);
            Controls.Add(enterUsernameLabel);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(loginUsernameTable);
            Controls.Add(loginPasswordTable);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void usernametextBox1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox loginPasswordTable;
        private TextBox loginUsernameTable;
        private Button button1;
        private Label label2;
        private CheckBox checkBox1;
        private Label enterUsernameLabel;
        private Label enterPasswordLabel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label label3;
        //private Label lblValidationMessage;
    }
}
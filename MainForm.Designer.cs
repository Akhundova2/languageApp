namespace LanguageApp2
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            studentsButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            languagesButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            teachersButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            feesButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            usersButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("HYMyeongJo-Extra", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(880, 69);
            label1.TabIndex = 0;
            label1.Text = "LANGUAGE APP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label2_Click;
            // 
            // studentsButton1
            // 
            studentsButton1.BackColor = Color.White;
            studentsButton1.DisabledState.BorderColor = Color.DarkGray;
            studentsButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            studentsButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            studentsButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            studentsButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentsButton1.ForeColor = Color.Gold;
            studentsButton1.Location = new Point(120, 136);
            studentsButton1.Name = "studentsButton1";
            studentsButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            studentsButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            studentsButton1.Size = new Size(154, 132);
            studentsButton1.TabIndex = 2;
            studentsButton1.Text = "STUDENTS";
            studentsButton1.Click += guna2CircleButton1_Click;
            // 
            // languagesButton1
            // 
            languagesButton1.BackColor = Color.White;
            languagesButton1.DisabledState.BorderColor = Color.DarkGray;
            languagesButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            languagesButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            languagesButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            languagesButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            languagesButton1.ForeColor = Color.Gold;
            languagesButton1.Location = new Point(614, 112);
            languagesButton1.Name = "languagesButton1";
            languagesButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            languagesButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            languagesButton1.Size = new Size(173, 156);
            languagesButton1.TabIndex = 3;
            languagesButton1.Text = "LANGUAGES";
            languagesButton1.Click += languagesButton1_Click;
            // 
            // teachersButton1
            // 
            teachersButton1.BackColor = Color.White;
            teachersButton1.DisabledState.BorderColor = Color.DarkGray;
            teachersButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            teachersButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            teachersButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            teachersButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teachersButton1.ForeColor = Color.Gold;
            teachersButton1.Location = new Point(120, 336);
            teachersButton1.Name = "teachersButton1";
            teachersButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            teachersButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            teachersButton1.Size = new Size(154, 132);
            teachersButton1.TabIndex = 4;
            teachersButton1.Text = "TEACHERS";
            teachersButton1.Click += teachersButton1_Click;
            // 
            // feesButton1
            // 
            feesButton1.BackColor = Color.White;
            feesButton1.DisabledState.BorderColor = Color.DarkGray;
            feesButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            feesButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            feesButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            feesButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feesButton1.ForeColor = Color.Gold;
            feesButton1.Location = new Point(635, 336);
            feesButton1.Name = "feesButton1";
            feesButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            feesButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            feesButton1.Size = new Size(137, 132);
            feesButton1.TabIndex = 5;
            feesButton1.Text = "FEES";
            feesButton1.Click += feesButton1_Click;
            // 
            // usersButton1
            // 
            usersButton1.BackColor = Color.White;
            usersButton1.DisabledState.BorderColor = Color.DarkGray;
            usersButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            usersButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            usersButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            usersButton1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersButton1.ForeColor = Color.Gold;
            usersButton1.Location = new Point(378, 217);
            usersButton1.Name = "usersButton1";
            usersButton1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            usersButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            usersButton1.Size = new Size(137, 132);
            usersButton1.TabIndex = 6;
            usersButton1.Text = "USERS";
            usersButton1.Click += guna2CircleButton5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(378, 464);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 7;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("HYPMokGak-Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(844, -2);
            label2.Name = "label2";
            label2.Size = new Size(35, 40);
            label2.TabIndex = 8;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(879, 539);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(usersButton1);
            Controls.Add(feesButton1);
            Controls.Add(teachersButton1);
            Controls.Add(languagesButton1);
            Controls.Add(studentsButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton studentsButton1;
        private Guna.UI2.WinForms.Guna2CircleButton languagesButton1;
        private Guna.UI2.WinForms.Guna2CircleButton teachersButton1;
        private Guna.UI2.WinForms.Guna2CircleButton feesButton1;
        private Guna.UI2.WinForms.Guna2CircleButton usersButton1;
        private Button button1;
        private Label label2;
    }
}
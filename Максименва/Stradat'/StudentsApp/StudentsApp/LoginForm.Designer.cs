namespace StudentsApp
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.usernameText = new System.Windows.Forms.TextBox();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.userTypeCombo = new System.Windows.Forms.ComboBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.usernameLabel.Location = new System.Drawing.Point(134, 77);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(77, 28);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "Логин";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordLabel.Location = new System.Drawing.Point(134, 135);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(90, 28);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Пароль";
			this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(134, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Статус";
			// 
			// usernameText
			// 
			this.usernameText.Location = new System.Drawing.Point(293, 77);
			this.usernameText.Name = "usernameText";
			this.usernameText.Size = new System.Drawing.Size(234, 35);
			this.usernameText.TabIndex = 3;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(293, 135);
			this.passwordText.Name = "passwordText";
			this.passwordText.PasswordChar = '*';
			this.passwordText.Size = new System.Drawing.Size(234, 35);
			this.passwordText.TabIndex = 4;
			// 
			// userTypeCombo
			// 
			this.userTypeCombo.FormattingEnabled = true;
			this.userTypeCombo.Items.AddRange(new object[] {
            "Student",
            "Employee",
            "Admin"});
			this.userTypeCombo.Location = new System.Drawing.Point(293, 195);
			this.userTypeCombo.Name = "userTypeCombo";
			this.userTypeCombo.Size = new System.Drawing.Size(234, 35);
			this.userTypeCombo.TabIndex = 5;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.White;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginButton.Location = new System.Drawing.Point(134, 275);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(337, 48);
			this.loginButton.TabIndex = 6;
			this.loginButton.Text = "ОК?";
			this.loginButton.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(226, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "Авторизация";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(627, 361);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.userTypeCombo);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.usernameText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autorization";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private Label label3;
        private TextBox usernameText;
        private TextBox passwordText;
        private ComboBox userTypeCombo;
        private Button loginButton;
		private Label label1;
	}
}
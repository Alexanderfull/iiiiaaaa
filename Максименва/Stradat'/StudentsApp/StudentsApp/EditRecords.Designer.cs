namespace StudentsApp
{
    partial class EditRecords
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecords));
			this.nameLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.majorLabel = new System.Windows.Forms.Label();
			this.gpaLabel = new System.Windows.Forms.Label();
			this.nameText = new System.Windows.Forms.TextBox();
			this.surnameText = new System.Windows.Forms.TextBox();
			this.gpaText = new System.Windows.Forms.TextBox();
			this.majorCombo = new System.Windows.Forms.ComboBox();
			this.studentListGrid = new System.Windows.Forms.DataGridView();
			this.saveRecordButton = new System.Windows.Forms.Button();
			this.EditRecordButton = new System.Windows.Forms.Button();
			this.DeleteRecordButton = new System.Windows.Forms.Button();
			this.loginLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginText = new System.Windows.Forms.TextBox();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.searchFeature = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameLabel.Location = new System.Drawing.Point(24, 45);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(51, 28);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Имя";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.surnameLabel.Location = new System.Drawing.Point(477, 45);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(103, 28);
			this.surnameLabel.TabIndex = 1;
			this.surnameLabel.Text = "Фамилия";
			// 
			// majorLabel
			// 
			this.majorLabel.AutoSize = true;
			this.majorLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.majorLabel.Location = new System.Drawing.Point(24, 139);
			this.majorLabel.Name = "majorLabel";
			this.majorLabel.Size = new System.Drawing.Size(90, 28);
			this.majorLabel.TabIndex = 2;
			this.majorLabel.Text = "Статус";
			// 
			// gpaLabel
			// 
			this.gpaLabel.AutoSize = true;
			this.gpaLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gpaLabel.Location = new System.Drawing.Point(477, 139);
			this.gpaLabel.Name = "gpaLabel";
			this.gpaLabel.Size = new System.Drawing.Size(51, 28);
			this.gpaLabel.TabIndex = 3;
			this.gpaLabel.Text = "GPA";
			// 
			// nameText
			// 
			this.nameText.Location = new System.Drawing.Point(124, 37);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(295, 35);
			this.nameText.TabIndex = 4;
			// 
			// surnameText
			// 
			this.surnameText.Location = new System.Drawing.Point(663, 37);
			this.surnameText.Name = "surnameText";
			this.surnameText.Size = new System.Drawing.Size(198, 35);
			this.surnameText.TabIndex = 5;
			// 
			// gpaText
			// 
			this.gpaText.Location = new System.Drawing.Point(663, 136);
			this.gpaText.Name = "gpaText";
			this.gpaText.Size = new System.Drawing.Size(198, 35);
			this.gpaText.TabIndex = 6;
			// 
			// majorCombo
			// 
			this.majorCombo.FormattingEnabled = true;
			this.majorCombo.Items.AddRange(new object[] {
            "Agriculture",
            "Arts",
            "Business",
            "Communications",
            "Community Services",
            "Engineering & Technology",
            "Economics",
            "Nursing",
            "Psychology",
            "English Language and Literature"});
			this.majorCombo.Location = new System.Drawing.Point(124, 136);
			this.majorCombo.Name = "majorCombo";
			this.majorCombo.Size = new System.Drawing.Size(295, 35);
			this.majorCombo.TabIndex = 7;
			// 
			// studentListGrid
			// 
			this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentListGrid.Location = new System.Drawing.Point(24, 257);
			this.studentListGrid.Name = "studentListGrid";
			this.studentListGrid.RowHeadersWidth = 51;
			this.studentListGrid.RowTemplate.Height = 25;
			this.studentListGrid.Size = new System.Drawing.Size(867, 316);
			this.studentListGrid.TabIndex = 8;
			// 
			// saveRecordButton
			// 
			this.saveRecordButton.BackColor = System.Drawing.Color.White;
			this.saveRecordButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.saveRecordButton.Location = new System.Drawing.Point(24, 591);
			this.saveRecordButton.Name = "saveRecordButton";
			this.saveRecordButton.Size = new System.Drawing.Size(167, 49);
			this.saveRecordButton.TabIndex = 9;
			this.saveRecordButton.Text = "Сохранить";
			this.saveRecordButton.UseVisualStyleBackColor = false;
			// 
			// EditRecordButton
			// 
			this.EditRecordButton.BackColor = System.Drawing.Color.White;
			this.EditRecordButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EditRecordButton.Location = new System.Drawing.Point(373, 591);
			this.EditRecordButton.Name = "EditRecordButton";
			this.EditRecordButton.Size = new System.Drawing.Size(194, 49);
			this.EditRecordButton.TabIndex = 10;
			this.EditRecordButton.Text = "Редактировать";
			this.EditRecordButton.UseVisualStyleBackColor = false;
			// 
			// DeleteRecordButton
			// 
			this.DeleteRecordButton.BackColor = System.Drawing.Color.White;
			this.DeleteRecordButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteRecordButton.Location = new System.Drawing.Point(724, 591);
			this.DeleteRecordButton.Name = "DeleteRecordButton";
			this.DeleteRecordButton.Size = new System.Drawing.Size(167, 49);
			this.DeleteRecordButton.TabIndex = 11;
			this.DeleteRecordButton.Text = "Удалить";
			this.DeleteRecordButton.UseVisualStyleBackColor = false;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginLabel.Location = new System.Drawing.Point(24, 88);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(77, 28);
			this.loginLabel.TabIndex = 12;
			this.loginLabel.Text = "Логин";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordLabel.Location = new System.Drawing.Point(477, 88);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(90, 28);
			this.passwordLabel.TabIndex = 13;
			this.passwordLabel.Text = "Пароль";
			// 
			// loginText
			// 
			this.loginText.Location = new System.Drawing.Point(124, 85);
			this.loginText.Name = "loginText";
			this.loginText.Size = new System.Drawing.Size(295, 35);
			this.loginText.TabIndex = 14;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(663, 85);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(198, 35);
			this.passwordText.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(24, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 28);
			this.label1.TabIndex = 16;
			this.label1.Text = "Поиск по должности";
			// 
			// searchFeature
			// 
			this.searchFeature.FormattingEnabled = true;
			this.searchFeature.Items.AddRange(new object[] {
            "Agriculture",
            "Arts",
            "Business",
            "Communications",
            "Community Services",
            "Engineering & Technology",
            "Economics",
            "Nursing",
            "Psychology",
            "English Language and Literature"});
			this.searchFeature.Location = new System.Drawing.Point(323, 209);
			this.searchFeature.Name = "searchFeature";
			this.searchFeature.Size = new System.Drawing.Size(486, 35);
			this.searchFeature.TabIndex = 17;
			// 
			// EditRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(923, 652);
			this.Controls.Add(this.searchFeature);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.loginText);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.DeleteRecordButton);
			this.Controls.Add(this.EditRecordButton);
			this.Controls.Add(this.saveRecordButton);
			this.Controls.Add(this.studentListGrid);
			this.Controls.Add(this.majorCombo);
			this.Controls.Add(this.gpaText);
			this.Controls.Add(this.surnameText);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.gpaLabel);
			this.Controls.Add(this.majorLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.nameLabel);
			this.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "EditRecords";
			this.Text = "EditRecords";
			this.Load += new System.EventHandler(this.EditRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label surnameLabel;
        private Label majorLabel;
        private Label gpaLabel;
        private TextBox nameText;
        private TextBox surnameText;
        private TextBox gpaText;
        private ComboBox majorCombo;
        private DataGridView studentListGrid;
        private Button saveRecordButton;
        private Button EditRecordButton;
        private Button DeleteRecordButton;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox loginText;
        private TextBox passwordText;
        private Label label1;
        private ComboBox searchFeature;
    }
}
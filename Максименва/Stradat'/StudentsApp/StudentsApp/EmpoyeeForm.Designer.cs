﻿namespace StudentsApp
{
    partial class EmpoyeeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpoyeeForm));
			this.exitButton = new System.Windows.Forms.Button();
			this.changeRecordsButton = new System.Windows.Forms.Button();
			this.viewStudentsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.White;
			this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(69)))), ((int)(((byte)(138)))));
			this.exitButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.exitButton.ForeColor = System.Drawing.Color.Black;
			this.exitButton.Location = new System.Drawing.Point(12, 176);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(254, 76);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Выход";
			this.exitButton.UseVisualStyleBackColor = false;
			// 
			// changeRecordsButton
			// 
			this.changeRecordsButton.BackColor = System.Drawing.Color.White;
			this.changeRecordsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.changeRecordsButton.FlatAppearance.BorderSize = 0;
			this.changeRecordsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(118)))), ((int)(((byte)(181)))));
			this.changeRecordsButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.changeRecordsButton.ForeColor = System.Drawing.Color.Black;
			this.changeRecordsButton.Location = new System.Drawing.Point(12, 94);
			this.changeRecordsButton.Name = "changeRecordsButton";
			this.changeRecordsButton.Size = new System.Drawing.Size(254, 76);
			this.changeRecordsButton.TabIndex = 4;
			this.changeRecordsButton.Text = "Изменить";
			this.changeRecordsButton.UseVisualStyleBackColor = false;
			// 
			// viewStudentsButton
			// 
			this.viewStudentsButton.BackColor = System.Drawing.Color.White;
			this.viewStudentsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.viewStudentsButton.FlatAppearance.BorderSize = 0;
			this.viewStudentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(161)))), ((int)(((byte)(220)))));
			this.viewStudentsButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.viewStudentsButton.ForeColor = System.Drawing.Color.Black;
			this.viewStudentsButton.Location = new System.Drawing.Point(12, 12);
			this.viewStudentsButton.Name = "viewStudentsButton";
			this.viewStudentsButton.Size = new System.Drawing.Size(254, 76);
			this.viewStudentsButton.TabIndex = 3;
			this.viewStudentsButton.Text = "Просмотр студентов";
			this.viewStudentsButton.UseVisualStyleBackColor = false;
			// 
			// EmpoyeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(292, 283);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.changeRecordsButton);
			this.Controls.Add(this.viewStudentsButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmpoyeeForm";
			this.Text = "Emploee";
			this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private Button changeRecordsButton;
        private Button viewStudentsButton;
    }
}
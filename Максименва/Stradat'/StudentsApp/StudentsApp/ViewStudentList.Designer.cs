namespace StudentsApp
{
    partial class ViewStudentList
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
			this.studentListGrid = new System.Windows.Forms.DataGridView();
			this.studentListLabel = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// studentListGrid
			// 
			this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentListGrid.Location = new System.Drawing.Point(12, 56);
			this.studentListGrid.Name = "studentListGrid";
			this.studentListGrid.RowTemplate.Height = 25;
			this.studentListGrid.Size = new System.Drawing.Size(776, 315);
			this.studentListGrid.TabIndex = 0;
			// 
			// studentListLabel
			// 
			this.studentListLabel.AutoSize = true;
			this.studentListLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.studentListLabel.Location = new System.Drawing.Point(288, 9);
			this.studentListLabel.Name = "studentListLabel";
			this.studentListLabel.Size = new System.Drawing.Size(236, 27);
			this.studentListLabel.TabIndex = 1;
			this.studentListLabel.Text = "Список студентов";
			this.studentListLabel.Click += new System.EventHandler(this.studentListLabel_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.White;
			this.exitButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.exitButton.Location = new System.Drawing.Point(245, 390);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(317, 48);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Выход";
			this.exitButton.UseVisualStyleBackColor = false;
			// 
			// ViewStudentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.studentListLabel);
			this.Controls.Add(this.studentListGrid);
			this.Name = "ViewStudentList";
			this.Text = "Student List";
			((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DataGridView studentListGrid;
        private Label studentListLabel;
        private Button exitButton;
    }
}
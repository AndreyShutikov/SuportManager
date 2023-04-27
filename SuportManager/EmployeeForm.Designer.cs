namespace SuportManager
{
    partial class EmployeeForm
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
            this.readButton = new System.Windows.Forms.Button();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.readButton.Location = new System.Drawing.Point(284, 391);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(193, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Чтение данных из базы";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Location = new System.Drawing.Point(58, 43);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.Size = new System.Drawing.Size(588, 150);
            this.dataGridEmployees.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridEmployees);
            this.Controls.Add(this.readButton);
            this.Name = "EmployeeForm";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.DataGridView dataGridEmployees;
    }
}
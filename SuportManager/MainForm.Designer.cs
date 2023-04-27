namespace SuportManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeButon
            // 
            this.EmployeeButon.Location = new System.Drawing.Point(206, 27);
            this.EmployeeButon.Name = "EmployeeButon";
            this.EmployeeButon.Size = new System.Drawing.Size(212, 79);
            this.EmployeeButon.TabIndex = 0;
            this.EmployeeButon.Text = "Сотрудники";
            this.EmployeeButon.UseVisualStyleBackColor = true;
            this.EmployeeButon.Click += new System.EventHandler(this.EmployeeButon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 628);
            this.Controls.Add(this.EmployeeButon);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeButon;
    }
}


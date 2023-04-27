using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuportManager
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
          
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора текстового файла
            string path = @"*\подкаталог_1\подкаталог_2\файл.txt";
            string contents = File.ReadAllText(path);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Чтение данных из выбранного текстового файла
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                // Создание объектов класса на основе прочитанных данных
                List<Employees> employees = new List<Employees>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    Employees employeesClass = new Employees();
                    employeesClass.TabelNumber = parts[0];
                    employeesClass.LastName = parts[1];
                    employeesClass.FirstName = parts[2];
                    employeesClass.Patronymic = parts[3];
                    employees.Add(employeesClass);
                }

                // Заполнение DataGridView данными из объектов класса
                dataGridEmployees.DataSource = employees;
            }
        }

    }
    
}

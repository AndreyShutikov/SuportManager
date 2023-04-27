using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuportManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void EmployeeButon_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            EmployeeForm employeeForm = new EmployeeForm();         
            employeeForm.Show();         
           
        }

       
    }
}

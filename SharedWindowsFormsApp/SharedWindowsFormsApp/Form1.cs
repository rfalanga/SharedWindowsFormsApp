using System;
using System.Windows.Forms;
using MySharedProject;

namespace SharedWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            string result = employee.GetEmployeeDetail();
            lblDetails.Text = result;
        }
    }
}

using BAL;
using log4net;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class SaveEmployee : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public SaveEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Employees emp = new Employees();
            emp.EmployeeName = textBox1.Text;
            emp.Department = textBox2.Text;
            if(cmbbxEmpt.SelectedText == "Permenent")
            {
                emp.EmployeeTypeId = 1;
            }
            else
            {
                emp.EmployeeTypeId = 2;
            }
            EmployeeManager empm = new EmployeeManager();
            empm.SaveEmployeeData(emp);
            lblSavedchanges.Text = "Employee Data Addded Successfully";
            _log.Info("Employee Data Addded Successfully");
        }

        private void Navbtn_Click(object sender, EventArgs e)
        {
            NavigationForm ng = new NavigationForm();
            ng.Show();
            Hide();
        }
    }
}

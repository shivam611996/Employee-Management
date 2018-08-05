using BAL;
using log4net;
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
    public partial class DeleteEmployee : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        EmployeeManager em = new EmployeeManager();
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void Navbtn_Click(object sender, EventArgs e)
        {
            NavigationForm ng = new NavigationForm();
            ng.Show();
            Hide();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(txtEmpId.Text);
            em.DeleteEmployeeData(empId);
            lblSearchData.Text = "Employee deleted successfully";
            _log.Info("Employee deleted successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(txtEmpId.Text);
            
            if(em.SearchEmployeeData(empId)!=null)
            {
                lblSearchData.Text = "Data Found...Do you want to delete this?";
                _log.Info("Employee search done...");
            }
            else
            {
                lblSearchData.Text = "Data Not Found...";
                _log.Info("Employee not found...");
            }
        }
    }
}

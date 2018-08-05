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
    public partial class ShowEmplyees : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public ShowEmplyees()
        {
            InitializeComponent();
        }

        private void Navbtn_Click(object sender, EventArgs e)
        {
            NavigationForm ng = new NavigationForm();
            ng.Show();
            Hide();
        }

        private void ShowEmplyees_Load(object sender, EventArgs e)
        {
            EmployeeManager em = new EmployeeManager();
            grdDataShow.DataSource = em.ShowEmployeeData();
            _log.Info("Employee Data Displayed");
        }
    }
}

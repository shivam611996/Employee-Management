using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            SaveEmployee f = new SaveEmployee();
            f.Show();
            Hide();
        }

        private void btnUpdEmp_Click(object sender, EventArgs e)
        {
            UpdateEmployee up = new UpdateEmployee();
            up.Show();
            Hide();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            DeleteEmployee dl = new DeleteEmployee();
            dl.Show();
            Hide();
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            ShowEmplyees sh = new ShowEmplyees();
            sh.Show();
            Hide();
        }

    }
}

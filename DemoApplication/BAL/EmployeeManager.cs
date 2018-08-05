using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeManager
    {
        EmployeeCommandRepository ecr = new EmployeeCommandRepository();
        EmployeeQueryRepository eqr = new EmployeeQueryRepository();
        EmployeeManagerFactory clp = new EmployeeManagerFactory();
        
        public void SaveEmployeeData(Employees emp)
        {
            IEmployeeManager imp = clp.DecideAndCalculate(emp.EmployeeTypeId);
            emp.Bonusinc = imp.GetBonus();
            emp.HourlyPay = imp.GetHourlyPay();
            ecr.SaveEmployee(emp);
        }

        public void UpdateEmployeeData(Employees emp)
        {
            IEmployeeManager imp = clp.DecideAndCalculate(emp.EmployeeTypeId);
            emp.Bonusinc = imp.GetBonus();
            emp.HourlyPay = imp.GetHourlyPay();
            ecr.UpdateEmployee(emp);
        }
        public Employees SearchEmployeeData(int empId)
        {
            Employees emp = eqr.SearchResult(empId);
            return emp;
        }
        public void DeleteEmployeeData(int empId)
        {
            ecr.DeleteEmployee(empId);
        }
        public DataTable ShowEmployeeData()
        {
            DataTable emp = eqr.ShowEmployees();
            return emp;
        }
    }
}

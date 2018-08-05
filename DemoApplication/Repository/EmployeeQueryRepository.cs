using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepository
    {
        public Employees SearchResult(int EmpId)
        {
            SqlDataReader sdr = DbClass.ExecuteReader("sp_SearchEmployeeData", System.Data.CommandType.StoredProcedure,
                                                        new SqlParameter("@EmployeeId",EmpId)
                                                     );
            Employees emp=new Employees();
            while(sdr.Read())
            {
                emp.EmployeeName = sdr["EmpName"].ToString();
                emp.Department = sdr["Dept"].ToString();
                emp.EmployeeTypeId = Convert.ToInt32(sdr["EmpTypeId"]);
            }
            return emp;
        }
        public DataTable ShowEmployees()
        {
            SqlDataReader sdr = DbClass.ExecuteReader("sp_GetAll", System.Data.CommandType.StoredProcedure);
            DataTable listEmployee = new DataTable();
            listEmployee.Load(sdr);
            return listEmployee;
        }
    }
}

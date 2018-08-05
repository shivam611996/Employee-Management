using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeCommandRepository
    {
        public void SaveEmployee(Employees emp)
        {
            DbClass.ExecuteNonQuery("sp_InsertData", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@EmployeeName", emp.EmployeeName),
                                    new SqlParameter("@Department", emp.Department),
                                    new SqlParameter("@EmployeeTypeId", emp.EmployeeTypeId),
                                    new SqlParameter("@HourlyPay", emp.HourlyPay),
                                    new SqlParameter("@BonusInc", emp.Bonusinc)
                                    ); 
        }
        public void UpdateEmployee(Employees emp)
        {
            DbClass.ExecuteNonQuery("sp_UpdateData", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@EmployeeId", emp.EmployeeId),
                                    new SqlParameter("@EmployeeName", emp.EmployeeName),
                                    new SqlParameter("@Department", emp.Department),
                                    new SqlParameter("@EmployeeTypeId", emp.EmployeeTypeId),
                                    new SqlParameter("@HourlyPay", emp.HourlyPay),
                                    new SqlParameter("@BonusInc", emp.Bonusinc)
                                    );
        }
        public void DeleteEmployee(int empId)
        {
            DbClass.ExecuteNonQuery("sp_DeleteData", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@EmployeeId", empId)
                                    );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ContractEmployeeType : IEmployeeManager
    {
        public int GetHourlyPay()
        {
            return 15;
        }

        public int GetBonus()
        {
            return 3;
        }
    }
}

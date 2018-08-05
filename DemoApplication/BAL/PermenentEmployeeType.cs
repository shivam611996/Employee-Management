using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PermenentEmployee : IEmployeeManager
    {

        public int GetHourlyPay()
        {
            return 20;
        }

        public int GetBonus()
        {
            return 5;
        }
    }
}

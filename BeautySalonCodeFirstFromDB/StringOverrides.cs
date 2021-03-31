using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonCodeFirstFromDB
{
    public partial class Employee
    {
        public override string ToString()
        {
            return $"{this.EmployeeLastName}, {this.EmployeeFirstName}";
        }
    }

    public partial class Client
    {
        public override string ToString()
        {
            return $"{this.ClientLastName}, {this.ClientFirstName} => {this.ClientPhoneNumber}";
        }
    }

    public partial class Service
    {
        public override string ToString()
        {
            return $"{this.ServiceName} ==> " + String.Format("{0:C}", this.ServicePrice);
        }
    }
}

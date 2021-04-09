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
            // Formatting the phone number
            String phone = "";
            String phone1 = "";
            String phone2 = "";
            String phone3 = "";
            try
            {
                phone = this.ClientPhoneNumber;
                phone1 = phone.Substring(0, 3);
                phone2 = phone.Substring(3, 3);
                phone3 = phone.Substring(6);
            } catch (Exception ex)
            {
                
            }
            
            return $"{this.ClientLastName}, {this.ClientFirstName} => " + String.Format("{0}-{1}-{2}", phone1, phone2, phone3);
        }
    }

    public partial class Service
    {
        public override string ToString()
        {
            return $"{this.ServiceName} ==> " + String.Format("{0:C}", this.ServicePrice);
        }
    }

    public partial class Appointment
    {
        public override string ToString()
        {
            //Find the client name
            BeautySalonEntities context = new BeautySalonEntities();
            var client = this.ClientId;
            
            return $"{this.AppointmentDate} ==> {this.AppointmentTime}, {context.Clients.Find(client)}";
        }
    }

    public partial class Inventory
    {
        public override string ToString()
        {
            //Find the client name
            BeautySalonEntities context = new BeautySalonEntities();
            var product = this.ProductId;

            return $"{this.ProductName}";
        }
    }
}

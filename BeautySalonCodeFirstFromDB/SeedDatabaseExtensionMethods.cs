using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity;

namespace BeautySalonCodeFirstFromDB
{
    public static class SeedDatabaseExtensionMethods
    {
        public static void SeedDatabase(this BeautySalonEntities context)
        {
            // Write log to output window
            context.Database.Log = s => Debug.Write(s);

            context.Database.Delete();
            context.Database.Create();

            context.SaveChanges();

            // First drop table views
            context.Database.ExecuteSqlCommand("drop table AppointmentsView");
            context.Database.ExecuteSqlCommand("drop table ServiceInventoryView");

            // Create views here
            string createView = "Create View[dbo].[AppointmentsView] AS " +
                "SELECT [Appointments].AppointmentDate, [Appointments]. AppointmentTime, " +
                "[Clients].ClientFirstName, [Clients].ClientLastName, [Employees].EmployeeFirstName, " +
                "[Employees].EmployeeLastName,  [Services].ServiceName, [Services].ServicePrice " +
                "FROM [Appointments] inner join [Clients] on [Clients].ClientId = [Appointments].ClientId " +
                "inner join [Services] on [Services].ServiceId = [Appointments].ServiceId " +
                "inner join [Employees] on [Employees].EmployeeId = [Appointments].EmployeeId;";

            //Create ServiceInventoryView
            string createServicesView = "Create View[dbo].[ServiceInventoryView] AS " +
            "SELECT [Services].ServiceId, [Services].ServiceName, [Services].ServicePrice, [Inventory].ProductId, [Inventory].ProductName, [Inventory].ProductQuantity " +
            "FROM [Services] " +
            "INNER JOIN [Inventory] " +
            "ON [Services].ProductId = [Inventory].ProductId";

            // Execute SQL command
            context.Database.ExecuteSqlCommand(createView);
            context.Database.ExecuteSqlCommand(createServicesView);

            context.SaveChanges();

            // Load the tables
/*            context.Clients.Load();
            context.Inventories.Load();
            context.Employees.Load();
            context.Services.Load();
            context.Appointments.Load();
            context.Payments.Load();*/


            // List of Clients
            List<Client> clients = new List<Client>()
            {
                new Client { ClientFirstName = "Rachel", ClientLastName = "Green", ClientPhoneNumber = "5555555555"},
                new Client { ClientFirstName = "Monica", ClientLastName = "Geller", ClientPhoneNumber = "5555555555"},
                new Client { ClientFirstName = "Ross", ClientLastName = "Geller", ClientPhoneNumber = "5555555555"},
                new Client { ClientFirstName = "Chandler", ClientLastName = "Bing", ClientPhoneNumber = "5555555555"},
                new Client { ClientFirstName = "Phoebe", ClientLastName = "Buffay", ClientPhoneNumber = "5555555555"},
                new Client { ClientFirstName = "Joey", ClientLastName = "Tribiani", ClientPhoneNumber = "5555555555"}
            };
            context.Clients.AddRange(clients);
            context.SaveChanges();

            // List of Employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmployeeFirstName = "Daenerys", EmployeeLastName = "Targaryen"},
                new Employee { EmployeeFirstName = "John", EmployeeLastName = "Snow"},
                new Employee { EmployeeFirstName = "Cersei", EmployeeLastName = "Lannister"},
                new Employee { EmployeeFirstName = "Tyrion", EmployeeLastName = "Lannister"},
                new Employee { EmployeeFirstName = "Sansa", EmployeeLastName = "Stark"},
                new Employee { EmployeeFirstName = "Eddard", EmployeeLastName = "Stark"}
            };
            context.Employees.AddRange(employees);
            context.SaveChanges();

            // List of Inventory
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory { ProductName = "Shampoo", ProductQuantity = 1000},
                new Inventory { ProductName = "Conditioner", ProductQuantity = 1000},
                new Inventory { ProductName = "Hair Dye - Blond", ProductQuantity = 30},
                new Inventory { ProductName = "Hair Dye - Brown", ProductQuantity = 30},
                new Inventory { ProductName = "Hair Dye - Red", ProductQuantity = 30},
                new Inventory { ProductName = "Scissors", ProductQuantity = 10},
                new Inventory { ProductName = "Comb", ProductQuantity = 20},
                new Inventory { ProductName = "Brush", ProductQuantity = 20},
                new Inventory { ProductName = "Blow Dryer", ProductQuantity = 5}
            };
            context.Inventories.AddRange(inventories);
            context.SaveChanges();

            // List of Services
            List<Service> services = new List<Service>()
            {
                new Service { ServiceName = "Hair Cut", ServicePrice = 35.0M, Inventory = inventories[0]},
                new Service { ServiceName = "Wash and Dry", ServicePrice = 30.0M, Inventory = inventories[8]},
                new Service { ServiceName = "Full Color", ServicePrice = 130.0M, Inventory = inventories[2]},
                new Service { ServiceName = "Partial Color", ServicePrice = 70.0M, Inventory = inventories[3]},
                new Service { ServiceName = "Permanent Color", ServicePrice = 90.0M, Inventory = inventories[2]},
                new Service { ServiceName = "Perm", ServicePrice = 80.0M, Inventory = inventories[1] }
            };
            context.Services.AddRange(services);
            context.SaveChanges();

            // List of Appointments
            List<Appointment> appointments = new List<Appointment>()
            {
                new Appointment { AppointmentDate = "12-APR-2021", AppointmentTime = "01:00pm", Client = clients[0], Employee = employees[0], Service = services[0]},
                new Appointment { AppointmentDate = "20-FEB-2021", AppointmentTime = "02:00pm", Client = clients[1], Employee = employees[1], Service = services[1]},
                new Appointment { AppointmentDate = "13-APR-2021", AppointmentTime = "01:00pm", Client = clients[2], Employee = employees[2], Service = services[2]},
                new Appointment { AppointmentDate = "13-APR-2021", AppointmentTime = "02:00pm", Client = clients[3], Employee = employees[3], Service = services[3]},
                new Appointment { AppointmentDate = "13-APR-2021", AppointmentTime = "03:00pm", Client = clients[4], Employee = employees[4], Service = services[4]},
                new Appointment { AppointmentDate = "13-APR-2021", AppointmentTime = "04:00pm", Client = clients[5], Employee = employees[5], Service = services[5]}
            };
            context.Appointments.AddRange(appointments);
            context.SaveChanges();

            // List of Payments
            List<Payment> payments = new List<Payment>()
            {
                new Payment { Employee = employees[0], Appointment = appointments[0]},
                new Payment { Employee = employees[1], Appointment = appointments[1]},
                new Payment { Employee = employees[2], Appointment = appointments[2]},
                new Payment { Employee = employees[3], Appointment = appointments[3]},
                new Payment { Employee = employees[4], Appointment = appointments[4]},
                new Payment { Employee = employees[5], Appointment = appointments[5]}
            };
            context.Payments.AddRange(payments);
            context.SaveChanges();

            context.AppointmentsViews.Load();
        }
    }
}

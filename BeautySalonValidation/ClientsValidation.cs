using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalonCodeFirstFromDB;
using System.Diagnostics;


namespace BeautySalonValidation
{
    public static class ClientValidation
    {
        /// <summary>
        ///  Checks if the client already exists in the DB
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool ClientExists(this Client client)
        {
            using (BeautySalonEntities context = new BeautySalonEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Clients.Any(c => c.ClientFirstName == client.ClientFirstName && c.ClientLastName == client.ClientLastName);
            }
        }
        /// <summary>
        /// Validate if all fields to add clients are correct
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool InfoIsValid(this Client client)
        {
            return (client.ClientFirstName == null || client.ClientFirstName.Trim().Length == 0 ||
                client.ClientLastName == null || client.ClientLastName.Trim().Length == 0 ||
                client.ClientPhoneNumber == null || client.ClientPhoneNumber.Trim().Length == 0 ||
                client.ClientPhoneNumber.Trim().Length != 10);
        }
        /// <summary>
        /// Check if appointments already exist for the same time and day
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public static bool AppointmentExists(this Appointment appointment)
        {
            using(BeautySalonEntities context = new BeautySalonEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Appointments.Any(a => a.AppointmentDate == appointment.AppointmentDate && a.AppointmentTime == appointment.AppointmentTime);
            }
        }

    }
}

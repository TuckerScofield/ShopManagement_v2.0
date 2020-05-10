using System.Collections.Generic;

namespace ShopManagement_v2.Models
{
    public class AppointmentListViewModel
    {
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}

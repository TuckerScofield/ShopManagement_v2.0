namespace ShopManagement_v2.Models
{
    public class Appointment
    {
        public int TechnicianID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }

        //need a date field....

        public Technician Technician { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}

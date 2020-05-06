using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopManagement_v2.Models
{
    internal class SeedAppointments : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> entity)
        {
            //Add Date of appointment when figure out that part
            entity.HasData(
            new Appointment { TechnicianID = 1, CustomerID = 1, VehicleID = 1 },
            new Appointment { TechnicianID = 2, CustomerID = 2, VehicleID = 1 },
            new Appointment { TechnicianID = 3, CustomerID = 3, VehicleID = 1 }
            );
        }
    }
}

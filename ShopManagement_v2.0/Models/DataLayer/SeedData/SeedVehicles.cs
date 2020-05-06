using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopManagement_v2.Models
{
    public class SeedVehicles : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> entity)
        {
            entity.HasData(
                new Vehicle { VehicleID = 1, Year = 1967, Make="Chevy II", Model="Nova Wagon", Milage=243157},
                new Vehicle { VehicleID = 2, Year = 2018, Make = "Dodge", Model = "Challenger SRT Demon", Milage = 12437 },
                new Vehicle { VehicleID = 3, Year = 1993, Make = "Volvo", Model = "240", Milage = 1111111 }
            );
        }
    }
}

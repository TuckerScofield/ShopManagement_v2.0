using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopManagement_v2.Models
{
    internal class SeedTechnicians : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> entity)
        {
            entity.HasData(
                new Technician { TechnicianID = 1, FirstName = "Stephen", LastName = "King"},
                new Technician { TechnicianID = 2, FirstName = "Terry", LastName = "Goodkind" },
                new Technician { TechnicianID = 3, FirstName = "Patrick", LastName = "Rothfuss" },
                new Technician { TechnicianID = 4, FirstName = "Kevin", LastName = "Hearne" },
                new Technician { TechnicianID = 5, FirstName = "Brandon", LastName = "Sanderson" }
            );
        }
    }
}

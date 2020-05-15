using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopManagement_v2.Models
{
    internal class SeedCustomers : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.HasData(
                new Customer
                {
                    CustomerID = 1,
                    FirstName = "Han",
                    LastName = "Solo",
                    Address = "2nd Dune on the left, Tatooine",
                    Phone = 742-684-3541,
                    Email = "millenialfalcon@starwars.com"
                },
                new Customer
                {
                    CustomerID = 2,
                    FirstName = "Hal",
                    LastName = "Jordan",
                    Address = "Sector 2814 Earth Sector",
                    Phone = 852-456-2814,
                    Email = "inbrightestday@GLcorps.com"
                },
                new Customer
                {
                    CustomerID = 3,
                    FirstName = "John",
                    LastName = "Smith",
                    Address = "That place, over there",
                    Phone = 111-222-1234,
                    Email = "nobody@nowhere.com"
                }
            );
        }
    }
}

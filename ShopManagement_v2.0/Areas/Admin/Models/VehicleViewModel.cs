using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement_v2.Models
{
    public class VehicleViewModel : IValidatableObject
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

        public int[] SelectedCustomers { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext ctx)
        {
            if (SelectedCustomers == null)
            {
                yield return new ValidationResult(
                    "Please select at least one customer.",
                    new[] { nameof(SelectedCustomers) });
            }
        }
    }
}

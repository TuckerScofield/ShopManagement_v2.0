using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement_v2.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        [Required(ErrorMessage ="Please enter a Year.")]
        [Range (1900, 2021, ErrorMessage ="Year must be between 1900 and 2021.")]
        public int? Year { get; set; }

        [Required(ErrorMessage ="Please enter a vehicle Make.")]
        public string Make { get; set; }

        [Required(ErrorMessage ="Please enter a vehicle Model.")]
        public string Model { get; set; }

        [Required(ErrorMessage ="Please list your vehicles miles.")]
        [Range(0.0, 1000000, ErrorMessage ="Milage must be more than 0.")]
        public int? Milage { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}

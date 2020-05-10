using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ShopManagement_v2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a phone number in following format 1112223333.")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        //vehicle foreign key
        public string VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}

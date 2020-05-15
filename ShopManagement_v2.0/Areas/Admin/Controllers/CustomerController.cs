using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ShopManagement_v2.Models;

namespace ShopManagement_v2.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private Repository<Customer> data { get; set; }
        public CustomerController(ShopContext ctx) => data = new Repository<Customer>(ctx);
        public ViewResult Index()
        {
            var customers = data.List(new QueryOptions<Customer>
            {
                OrderBy = c => c.FirstName
            });
            return View(customers);
        }

        public RedirectToActionResult Select(int id, string operation)
        {
            switch (operation.ToLower())
            {
                case "view vehicles":
                    return RedirectToAction("ViewCars", new { id });
                case "edit":
                    return RedirectToAction("Edit", new { id });
                case "delete":
                    return RedirectToAction("Delete", new { id });
                default:
                    return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ViewResult Add() => View("Customer", new Customer());

        [HttpPost]
        public IActionResult Add(Customer customer, string operation)
        {

            if (ModelState.IsValid)
            {
                data.Insert(customer);
                data.Save();
                TempData["message"] = $"{customer.FullName} added to Customers.";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Customer", customer);
            }
        }

        [HttpGet]
        public ViewResult Edit(int id) => View("Customer", data.Get(id));

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                data.Update(customer);
                data.Save();
                TempData["message"] = $"{customer.FullName} updated.";
                return RedirectToAction("Index");
            }
            else
            {
                return View("Customer", customer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = data.Get(new QueryOptions<Customer>
            {
                Include = "Appointments",
                Where = c => c.CustomerID == id
            });

            if (customer.Appointments.Count > 0)
            {
                TempData["message"] = $"Can't delete customer {customer.FullName} because they are associated with these appointments.";
                return GoToCustomerSearch(customer);
            }
            else
            {
                return View("Customer", customer);
            }
        }

        [HttpPost]
        public RedirectToActionResult Delete(Customer customer)
        {
            data.Delete(customer);
            data.Save();
            TempData["message"] = $"{customer.FullName} removed from Customers.";
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ViewCars(int id)
        {
            var customer = data.Get(id);
            return GoToCustomerSearch(customer);
        }

        private RedirectToActionResult GoToCustomerSearch(Customer customer)
        {
            var search = new SearchData(TempData)
            {
                SearchTerm = customer.FullName,
                Type = "customer"
            };
            return RedirectToAction("Search", "Vehicle");
        }
    }
}
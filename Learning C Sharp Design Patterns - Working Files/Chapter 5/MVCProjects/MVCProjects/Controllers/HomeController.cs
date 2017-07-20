using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCProjects.Models;

namespace MVCProjects.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Customer> customers = GetDemoCustomers();
            return View(customers);
        }

        private List<Customer> GetDemoCustomers()
        {
            List<Customer> customers = new List<Customer>{
                new Customer {
                    CustomerID = 1,
                    FirstName = "William",
                    LastName = "Forbes",
                    Address = "8 Main St.",
                    City = "Sandy",
                    State = "UT",
                    PostalCode = "55555",
                    Country = "US",
                    Phone = "(555) 555-1212"
                },
                new Customer {
                    CustomerID = 2,
                    FirstName = "Debbie",
                    LastName = "Richmond",
                    Address = "25 Center St.",
                    City = "Wilton",
                    State = "CT",
                    PostalCode = "06555",
                    Country = "US",
                    Phone = "(203) 555-1212"
                }
            };
            return customers;
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            List<Customer> customers = GetDemoCustomers();
            Customer customer = customers.SingleOrDefault(c => c.CustomerID == id);
            return View(customer);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            List<Customer> customers = GetDemoCustomers();
            Customer customer = customers.SingleOrDefault(c => c.CustomerID == id);
            return View(customer);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            List<Customer> customers = GetDemoCustomers();
            Customer customer = customers.SingleOrDefault(c => c.CustomerID == id);
            return View(customer);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

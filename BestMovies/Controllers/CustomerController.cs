using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using BestMovies.Models;
using BestMovies.Persistance.Repositories;

namespace BestMovies.Controllers
{
    public class CustomerController : Controller
    {


        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = null;

         
                customers = new DB_Context().Customers.Include("Membership").ToList();
            
            //catch (Exception e)
            //{
            //    return Content("We dont have any customer Yet");
            //}

            return View(customers);
        }

        public ActionResult Details(int? id)
        {
           
            var customers = new DB_Context().Customers;

            Customer customer = null;
            try
            {
                customer = customers.Include("Membership").First(c => c.Id == id);
            }
            catch (Exception e)
            {
                return Content("We dont have this customer");
            }

            return View(customer);
        }
    }
}
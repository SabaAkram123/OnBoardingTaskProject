using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ReactTestingProject.Models;

namespace ReactTestingProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ONBORADING_TASK_DemoEntities db = new ONBORADING_TASK_DemoEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAllCustomers()
        {
            var Customerdatalist = db.Customer_Table.Select(x => new { x.Id, x.Name, x.Address }).ToList();

            return Json(new { success = true, data = Customerdatalist, responseText = "Successfully show all list of customers" });
        }
        [HttpPost]
        public JsonResult CreateNewCustomers(Customer_Table customer)
        {
            try
            {
                db.Customer_Table.Add(customer);
                db.SaveChanges();
                Console.Write("Successully Added");
            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");

                return Json(new { data = "Failing to create new customer" });
            }
            return Json(new { success = true, data = "Success created" });

        }
        [HttpPost]
        public JsonResult UpdateCustomer(Customer_Table customer)
        {
            try
            {
                var updatecustomer = db.Customer_Table.Where(x => x.Id == customer.Id).FirstOrDefault();
                updatecustomer.Name = customer.Name;
                updatecustomer.Address = customer.Address;
                db.SaveChanges();

                return Json(new { success = true, data = "updated Suceesfully" });

            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");
                return Json(new { success = false, data = "fail to Update record" });

            }
        }


        [HttpGet]
        //To Delete the record of a customer
        public JsonResult DeleteCustomer(int Id)
        {
            try
            {
                var customer = db.Customer_Table.Where(x => x.Id == Id).SingleOrDefault();
                if (customer != null)
                {
                    db.Customer_Table.Remove(customer);
                    db.SaveChanges();
                }
                return Json(new { success = true, responseText = "Successfully Deleted" });
            }
            catch (Exception e)
            {
                Console.Write(e.Data + "Exception Occured");

                return Json(new { success = false, responseText = " not Successfully Deleted" });

            }


        }
    }
}

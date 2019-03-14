using RZOsound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewCustomer(Customer postedCustomer)
        {
            Customer customer = new Customer();

            customer.customerID = Guid.NewGuid().ToString();
            customer.firstName = postedCustomer.firstName;
            customer.lastName = postedCustomer.lastName;
            customer.streetAddress = postedCustomer.streetAddress;
            customer.city = postedCustomer.city;
            customer.zipCode = postedCustomer.zipCode;
            customer.areaCode = postedCustomer.areaCode;
            customer.phoneNumber = postedCustomer.phoneNumber;

            return View(customer);

        }
        public ActionResult AddCustomer()
        {
            return View();

        }

        public ActionResult CustomerList()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer()
            {
                firstName = "Samuel",
                lastName = "McKnight",
                streetAddress = "1000 east Ash Lane",
                city = "Euless",
                zipCode = "76015",
                areaCode = "214",
                phoneNumber = "682-559-9795"
            });

            customers.Add(new Customer()
            {
                firstName = "Samuel",
                lastName = "McKnight",
                streetAddress = "1000 east Ash Lane",
                city = "Euless",
                zipCode = "76015",
                areaCode = "214",
                phoneNumber = "682-559-9795"
            });

            return View(customers);
        }
        public ActionResult ViewEmployee(Employee postedEmployee)
        {
            Employee employee = new Employee();

            employee.employeeID = Guid.NewGuid().ToString();
            employee.empfirstName = postedEmployee.empfirstName;
            employee.emplastName = postedEmployee.emplastName;
            employee.empstreetAddress = postedEmployee.empstreetAddress;
            employee.empcity = postedEmployee.empcity;
            employee.empzipCode = postedEmployee.empzipCode;
            employee.empareaCode = postedEmployee.empareaCode;
            employee.empphoneNumber = postedEmployee.empphoneNumber;

            return View(employee);

        }
        public ActionResult AddEmployee()
        {
            return View();

        }

        public ActionResult EmployeeList()
        {
            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee()
            {
                empfirstName = "Samuel",
                emplastName = "McKnight",
                empstreetAddress = "1000 east Ash Lane",
                empcity = "Euless",
                empzipCode = "76015",
                empareaCode = "214",
                empphoneNumber = "682-559-9795"
            });


            employee.Add(new Employee()
            {
                empfirstName = "Samuel",
                emplastName = "McKnight",
                empstreetAddress = "1000 east Ash Lane",
                empcity = "Euless",
                empzipCode = "76015",
                empareaCode = "214",
                empphoneNumber = "682-559-9795"
            });

            return View(employee);
        }
    }
}
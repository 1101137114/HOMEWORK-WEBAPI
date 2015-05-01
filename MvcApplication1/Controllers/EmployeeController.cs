using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        //
        // GET: /Employee/

        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        [ActionName("byname")]
        public IList<Employee> GetEmployeeByName(string name)
        {
            var employee = EmployeeService.GetEmployeeByName(name);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }
    }
}

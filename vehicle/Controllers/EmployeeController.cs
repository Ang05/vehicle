using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.IService;
using DAL.Models;
using DAL.Service;
using Microsoft.AspNetCore.Http;
using DAL.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace vehicle.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
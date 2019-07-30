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
    public class DepartmentController : Controller
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
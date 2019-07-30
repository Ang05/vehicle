using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;


namespace DAL.Data.ViewModels
{
    public class Department
    {
        public Department(department department)
        {
            Id = department.department_id;
            Name = department.department_name;
            Manager_Id = department.mgr_id;
        }

        public int Id { set; get; }
        public string Name { set; get; }
        public int Manager_Id { set; get; }
    }
}

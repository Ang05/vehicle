using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Data.ViewModels
{
    public class Employee
    {
        public Employee(employee employee)
        {
            Id = employee.id;
            first_name = employee.first_name;
            last_name = employee.last_name;
            gender = employee.gender;
            birth_date = employee.birth_date;
            address = employee.address;
            SupervisorId = employee.super_id;
            department_id = employee.department_id;
        }


        public int Id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string gender { set; get; }
        public DateTime birth_date { set; get; }
        public string address { set; get; }
        public int SupervisorId { set; get; }
        public int department_id { set; get; }
    }
}

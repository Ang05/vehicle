using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;



namespace DAL.IService
{
    public interface IEmployeeService
    {
        int AddEmployee(employee employee);
        IQueryable<employee> GetAllEmployees();
        employee GetEmployee(int id);
        void Update(employee employee);
        void Delete(int id);
    }
}

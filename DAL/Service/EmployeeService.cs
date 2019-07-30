using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;
using DAL.IService;

namespace DAL.Service
{
    public class EmployeeService : IEmployeeService
    {
        readonly vehiclecontext _entity = new vehiclecontext();
        
        public int AddEmployee(employee employee)
        {
            _entity.employee.Add(employee);
            _entity.SaveChanges();

            return employee.id;
        }

        public IQueryable<employee> GetAllEmployees()
        {
            return _entity.employee.AsQueryable();
        }
        public employee GetEmployee(int id)
        {
            return _entity.employee.FirstOrDefault(e => e.id == id);
        }
        public void Update(employee employee)
        {
            var old = _entity.employee.FirstOrDefault(e => e.id == employee.id);
            _entity.Entry(old).CurrentValues.SetValues(employee);
            _entity.SaveChanges();
        }
        public void Delete(int id)
        {
            _entity.employee.Remove(_entity.employee.FirstOrDefault(e => e.id == id));
            _entity.SaveChanges();
        }

    }
}

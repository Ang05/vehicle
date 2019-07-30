using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;
using DAL.IService;

namespace DAL.Service
{
    public class DepartmentService : IDepartmentService
    {
        readonly vehiclecontext _entity = new vehiclecontext();
        
        public int AddDepartment(department department)
        {
            _entity.department.Add(department);
            _entity.SaveChanges();

            return department.department_id;
        }

        public IQueryable<department> GetAllDepartments()
        {
            return _entity.department.AsQueryable();
        }
        public department GetDepartment(int department_id)
        {
            return _entity.department.FirstOrDefault(e => e.department_id == department_id);
        }
        public void Update(department department)
        {
            var old = _entity.department.FirstOrDefault(e => e.department_id == department.department_id);
            _entity.Entry(old).CurrentValues.SetValues(department);
            _entity.SaveChanges();
        }
        public void Delete(int department_id)
        {
            _entity.department.Remove(_entity.department.FirstOrDefault(e => e.department_id == department_id));
            _entity.SaveChanges();
        }

     }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;

namespace DAL.IService
{
    public interface IDepartmentService
    {
        int AddDepartment(department department);
        IQueryable<department> GetAllDepartments();
        department GetDepartment(int department_id);
        void Update(department department);
        void Delete(int department_id);
    }
}

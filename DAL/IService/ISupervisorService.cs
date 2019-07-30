using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;

namespace DAL.IService
{
    public interface ISupervisorService
    {
        int AddSupervisor(supervisor supervisor);
        int AddSupervisee(supervisor supervisor);
        IQueryable<supervisor> GetAllSupervisors();
        supervisor GetSupervisor(int super_id);
        IQueryable<supervisor> GetAllSupervisees(int sup_id);
        void Update(supervisor supervisor);
        void Delete(int super_id);
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;
using DAL.IService;

namespace DAL.Service
{
    public class SupervisorService : ISupervisorService
    {
        readonly vehiclecontext _entity = new vehiclecontext();

        public int AddSupervisor(supervisor supervisor)
        {
            _entity.supervisor.Add(supervisor);
            _entity.SaveChanges();

            return supervisor.super_id;
        }

        public int AddSupervisee(supervisor supervisor)
        {
            _entity.supervisor.Add(supervisor);
            _entity.SaveChanges();

            return supervisor.subord_id;
        }

        public IQueryable<supervisor> GetAllSupervisors()
        {
            return _entity.supervisor.AsQueryable();
        }
        public IQueryable<supervisor> GetAllSupervisees(int sup_id)
        {
            return _entity.supervisor.AsQueryable().Where(e => e.super_id == sup_id);
        }
        public supervisor GetSupervisor(int sub_id)
        {
            return _entity.supervisor.FirstOrDefault(e => e.subord_id == sub_id);
        }

        public void Update(supervisor supervisor)
        {
            var old = _entity.supervisor.FirstOrDefault(e => e.super_id == supervisor.super_id);
            _entity.Entry(old).CurrentValues.SetValues(supervisor);
            _entity.SaveChanges();
        }
        public void Delete(int super_id)
        {
            _entity.supervisor.Remove(_entity.supervisor.FirstOrDefault(e => e.super_id == super_id));
            _entity.SaveChanges();
        }

        
    }
}

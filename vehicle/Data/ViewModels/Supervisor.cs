using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DATA.ViewModels
{
    public class Supervisor
    {
        public Supervisor(supervisor supervisor)
        {
            SupervisorId = supervisor.super_id;
            SuperviseeId = supervisor.subord_id;
        }
                
        public int SupervisorId { set; get; }
        public int SuperviseeId { set; get; }
    }
}

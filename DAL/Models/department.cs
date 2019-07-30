using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class department
    {
        public int department_id { set; get; }
        public string department_name { set; get; }
        public int mgr_id { set; get; }
    }
}

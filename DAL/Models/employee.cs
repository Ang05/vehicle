using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class employee
    {
        public int id { set; get; }
        public string first_name { set; get; }
        public string last_name { set; get; }
        public string gender { set; get; }
        public DateTime birth_date { set; get; }
        public string address { set; get; }
        public int super_id { set; get; }
        public int department_id { set; get; }
    }
}

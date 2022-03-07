using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_ENTITY_CORE.Models;
namespace MVC_ENTITY_CORE.Models
{
    public class Company
    {
        public int id { get; set; }
        public string name{ get; set; }
        public string email{ get; set; }
        public string gender{ get; set; }
        public string mobile{ get; set; }
        public int department_id{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scripterx.LearningProject.ApiDev.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }
    }
}

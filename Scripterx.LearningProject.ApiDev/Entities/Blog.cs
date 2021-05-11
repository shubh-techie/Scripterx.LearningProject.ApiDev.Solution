using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scripterx.LearningProject.ApiDev.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }
    }
}

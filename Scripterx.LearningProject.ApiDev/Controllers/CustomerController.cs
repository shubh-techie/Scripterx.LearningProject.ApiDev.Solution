using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scripterx.LearningProject.ApiDev.Data;
using Scripterx.LearningProject.ApiDev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scripterx.LearningProject.ApiDev.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        public readonly ApplicationDbContext applicationDbContext;

        public CustomerController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await applicationDbContext.Customers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomers(int id)
        {
            return await applicationDbContext.Customers.FindAsync(id);
        }
    }
}

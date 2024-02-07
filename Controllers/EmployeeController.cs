using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prac06.data;
using prac06.models;

namespace prac06.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpDbContext _empDbContext;
        public EmployeeController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var employee = await _empDbContext.EmpTable.ToListAsync();
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployees([FromBody] Employee employee)
        {
            employee.Id = Guid.NewGuid();
            await _empDbContext.EmpTable.AddAsync(employee);
            await _empDbContext.SaveChangesAsync();
            return Ok(employee);
        }
    }
}
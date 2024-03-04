using FirstAPIApp.Data;
using FirstAPIApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly MyAppDbContext _context;

        public EmpController(MyAppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult getemployee()
        {
            var employee = _context.Employee.ToList();
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Addemp(Employees emp)
        {
            _context.Employee.Add(emp);
            _context.SaveChanges();
            return Ok(emp);
        }
        [HttpPut]
        public IActionResult UpdateEmp(int id,Employees emp)
        {
            _context.Entry(emp).State=EntityState.Modified;
            _context.SaveChanges();
            return Ok(emp);
        }
        [HttpDelete]
        public IActionResult Delemp(int id)
        {
            var emp = _context.Employee.Find(id);
            _context.Employee.Remove(emp);
            _context.SaveChanges();
            return Ok();
        }
    }
}

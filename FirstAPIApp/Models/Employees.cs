using System.ComponentModel.DataAnnotations;

namespace FirstAPIApp.Models
{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }
}

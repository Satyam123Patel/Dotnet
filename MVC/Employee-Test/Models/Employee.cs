using System.ComponentModel.DataAnnotations;

namespace Employee_Test.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public string empName { get; set; }

        public int deptId { get; set; }
    }
}

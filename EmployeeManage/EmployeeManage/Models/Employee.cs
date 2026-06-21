using System.ComponentModel.DataAnnotations;

namespace EmployeeManage.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int departmentId { get; set; }
    }
}

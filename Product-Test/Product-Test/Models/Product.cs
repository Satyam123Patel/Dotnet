using System.ComponentModel.DataAnnotations;

namespace Product_Test.Models
{
    public class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
    }
}

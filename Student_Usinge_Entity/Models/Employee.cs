using System.ComponentModel.DataAnnotations;

namespace Student_Usinge_Entity.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public  int MobNo { get; set; }
        public string Designation { get; set; } = "";
        public decimal Salary { get; set; }

    }
}

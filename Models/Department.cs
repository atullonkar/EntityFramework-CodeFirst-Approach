using System.ComponentModel.DataAnnotations;

namespace EfCodeFirst.Models
{
    public partial class Department
    {
       [Key]
        public int DeptNo { get; set; }
        public string DeptName { get; set; } = null!;
        public virtual ICollection<Employee>? Employees { get; set; }

    }
}

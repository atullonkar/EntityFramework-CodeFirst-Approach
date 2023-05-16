﻿using System.ComponentModel.DataAnnotations;

namespace EfCodeFirst.Models
{
    public partial class Employee
    {
        [Key]
        public int EmpNo { get; set; }
        public string Name { get; set; } = null!;
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

        public virtual Department? DeptNoNavigation { get; set; } = null!;
    }
}

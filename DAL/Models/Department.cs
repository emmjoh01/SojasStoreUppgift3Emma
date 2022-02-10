using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DepartmentProduct>? DepartmentProduct { get; set; } = new List<DepartmentProduct>();
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}

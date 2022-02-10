using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public List<Email> Emails { get; set; } = new List<Email>();
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public virtual Employee? Mentor { get; set; }
        public virtual List<Employee>? Trainee { get; set; }
    }
}

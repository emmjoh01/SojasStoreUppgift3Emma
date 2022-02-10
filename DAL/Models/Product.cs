using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DepartmentProduct> DepartmentProduct { get; set; } = new List<DepartmentProduct>();
        public int LastCheckedByEmployeeId { get; set; }
        public virtual Employee LastCheckedByEmployee { get; set; }
        public int AmountInStore { get; set; }
        public int Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime LastCheckedDate { get; set; }
        public virtual List<ProductIngredient>? ProductIngredients { get; set; } = new List<ProductIngredient>();
        public int? IsOnCampaignId { get; set; }
        public virtual Campaign? IsOnCampaign { get; set; }
    }
}

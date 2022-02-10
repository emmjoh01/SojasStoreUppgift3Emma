using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Campaign
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampaignId { get; set; }
        public decimal PercentPriceDrop { get; set; } 
        public virtual List<Product>? ProductsOnCampaign { get; set; } = new List<Product>();
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public virtual List<ProductIngredient> ProductIngredients { get; set; }
    }
}

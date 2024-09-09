using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FoodProd> FoodProds { get; set; } = [];
        //public Category Category { get; set; } = null!;
    }
}

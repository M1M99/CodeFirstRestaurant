using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
	class Dish
	{
        //food dish eyni seydir
        public int Id { get; set; }
        public float Price { get; set; }
        public int RestourantId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //public int MediaMenuId { get; set; }
        public ICollection<MediaMenu> DishList { get; set; } = [];
    }
}

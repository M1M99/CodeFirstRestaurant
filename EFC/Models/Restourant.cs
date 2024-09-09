using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class Restourant
    {
        public int  Id { get; set; }
        public string Name { get; set; } = null!;
        public string Num { get; set; }
        //public Rating Rate { get; set; } = null!;
        public int MediaResId { get; set; }
        public MediaRes MediaRes { get; set; }
        public ICollection<Rating> ratings { get; set; } = [];
        public int Category1Id { get; set; }
        public ICollection<FavoriteRestaurant> favoriteRestaurants { get; set; } = [];
        public ICollection<Dish> Dishes { get; set; }
    }
}

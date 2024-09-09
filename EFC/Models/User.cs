using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassW { get; set; }
        public string Mail { get; set; }
        public MediaUser? MediaUser { get; set; }
        public int MediaUserId { get; set; }
        public ICollection<FavoriteRestaurant> favoriteRestaurants { get; set; } = [];
    }
}

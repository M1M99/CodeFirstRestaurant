using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class FavoriteRestaurant
    {
        public int Id { get; set; }
        public int RestourantId { get; set; }
        public int UserId { get; set; }
    }
}

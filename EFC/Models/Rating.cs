using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class Rating
    {
        public int Id { get; set; }
        public int Rating_N { get; set; }
        public int RestourantId { get; set; }
        //public Restourant Restourants { get; set; }
        //ICollection<Restourant> Restourants { get; set; }
    }
}

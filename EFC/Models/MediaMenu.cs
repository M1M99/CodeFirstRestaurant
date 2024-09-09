using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class MediaMenu
    {
        public int Id { get; set; }
        public string? URL { get; set; }
        public Dish Dishs { get; set; }
    }
}

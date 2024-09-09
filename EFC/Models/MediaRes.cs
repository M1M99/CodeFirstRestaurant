using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class MediaRes
    {
        public int Id { get; set; }
        public string? URL { get; set; }
        public Restourant Res { get; set; }
    }
}

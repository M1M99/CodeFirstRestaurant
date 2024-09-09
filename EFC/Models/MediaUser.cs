using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Models
{
    internal class MediaUser
    {
        public int Id { get; set; }
        public string? URL { get; set; }
        public User User { get; set; }
    }
}

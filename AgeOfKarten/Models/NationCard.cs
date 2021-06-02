using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfKarten.Models
{
    public class NationCard
    {
        public int NationCardId { get; set; }

        public Card Card { get; set; }

        public Nation Nation { get; set; }

        public int Age { get; set; }

        public int Propability { get; set; }
    }
}

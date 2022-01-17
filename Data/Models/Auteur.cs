using System;
using System.Collections.Generic;

namespace OnlineBibliotheek.Data.Models
{
    public class Auteur
    {
        public Guid Id { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public DateTime Geboren { get; set; }

        public ICollection<Boek> Boeken { get; set; }
    }
}

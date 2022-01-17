using OnlineBibliotheek.Data.Enums;
using System;

namespace OnlineBibliotheek.Data.Models
{
    public class Boek
    {
        public Guid Id { get; set; }
        public string Naam { get; set; }
        public Genres Genre { get; set; }
        public decimal Prijs { get; set; }
        public Guid? AuteurId { get; set; }
        public Auteur? Auteur { get; set; }
    }
}

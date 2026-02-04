using System.ComponentModel.DataAnnotations;

namespace ApiMovie.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string Name { get; set; } // Director name
        public string Nationality { get; set; } // Director nationality
        public List<Movie> Movies { get; set; } = new(); // Navigation property
    }
}

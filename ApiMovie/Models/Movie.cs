using System.ComponentModel.DataAnnotations;

namespace ApiMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string Title { get; set; } // Movie title
        public string Description { get; set; } // Movie description
        public int DirectorId { get; set; } // Foreign key
        public Director Director { get; set; } // Navigation property
    }
}
namespace ApiMovie.DTOs
{
    // A DTO (data transfer object) defines how (which) data will be sent over the network
    public class CreateMovieDto
    {
        public string Title { get; set; } // Movie title
        public DirectorDto Director { get; set; } // Director information
        public string Description { get; set; } // Movie description
    }
}

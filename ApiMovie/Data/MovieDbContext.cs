using Microsoft.EntityFrameworkCore;
using ApiMovie.Models;

namespace ApiMovie.Data
{
    // Class representing the database context for movies and directors 
    public class MovieDbContext : DbContext 
    {
        // Constructor to pass options to the base DbContext
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        // Property DbSet for Movie entities (Movie table)
        public DbSet<ApiMovie.Models.Movie> Movies { get; set; }

        // Property DbSet for Director entities (Director table)
        public DbSet<ApiMovie.Models.Director> Directors { get; set; }

        // Method to seed initial data into the database 
        // This method is called when the model is being created, the model meaning the structure of the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Directors
            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, Name = "Jim Henson, Frank Oz", Nationality = "American" },
                new Director { Id = 2, Name = "The Wachowski Brothers", Nationality = "American" },
                new Director { Id = 3, Name = "Guillermo del Toro", Nationality = "Mexican" },
                new Director { Id = 4, Name = "Wolfgang Petersen", Nationality = "German" },
                new Director { Id = 5, Name = "Ridley Scott", Nationality = "British" }
            );

            // Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "The Dark Crystal",
                    Description = "The last of the Gelflings...",
                    DirectorId = 1
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Matrix",
                    Description = "A hacker named Neo discovers...",
                    DirectorId = 2
                },
                new Movie
                {
                    Id = 3,
                    Title = "Pan's Labyrinth",
                    Description = "In the falangist Spain of 1944...",
                    DirectorId = 3
                },
                new Movie
                {
                    Id = 4,
                    Title = "The NeverEnding Story",
                    Description = "A young boy becomes trapped in a book...",
                    DirectorId = 4
                },
                new Movie
                {
                    Id = 5,
                    Title = "Blade Runner",
                    Description = "In a dystopian Los Angeles...",
                    DirectorId = 5
                }
            );
        }
    }
}

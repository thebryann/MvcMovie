using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Price { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
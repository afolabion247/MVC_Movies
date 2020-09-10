using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using MVC_FinalProject.Models;

namespace MVC_FinalProject.Models
{
    //the Movie class to represent movies in a database.   
    //Each instance of a Movie object will correspond to a row within a database table,
    //and each property of the Movie class will map to a column in the table.

    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]// data validation
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }   ////another property added

    }





    //The MovieDBContext class represents the Entity Framework movie database context,
    //which handles fetching, storing, and updating Movie class instances in a database.

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}




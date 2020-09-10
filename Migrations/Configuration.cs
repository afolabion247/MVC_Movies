namespace MVC_FinalProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVC_FinalProject.Models;

    
    internal sealed class Configuration : DbMigrationsConfiguration<MVC_FinalProject.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        //this method updates rows that have already been inserted, or inserts them if they don't exist yet.
        protected override void Seed(MVC_FinalProject.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title, //ensures that title is a unique field
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Rating = "PG",
            Price = 7.99M
        },

         new Movie
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Rating = "G",
             Price = 8.99M
         },

         new Movie
         {
             Title = "Ghostbusters 2",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             Rating = "G",
             Price = 9.99M
         },

       new Movie
       {
           Title = "Rio Bravo",
           ReleaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Rating = "PG",
           Price = 3.99M
       }
   );

        }
    }
}

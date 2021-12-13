using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Entity_framework.Data;
using System;
using System.Linq;

namespace Entity_framework.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Entity_frameworkContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Entity_frameworkContext>>()))
            {
                // Look for any movies.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Games
                    {
                        Title = "Star Wars",
                        ReleaseDate = DateTime.Parse("1995-5-10"),
                        Rate = 4,
                        Price = 150.99M
                    },

                    new Games
                    {
                        Title = "Need For Speed",
                        ReleaseDate = DateTime.Parse("2005-11-25"),
                        Rate = 5,
                        Price = 58.50M
                    },

                    new Games
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-05-10"),
                        Rate = 5,
                        Price = 320.10M
                    },

                    new Games
                    {
                        Title = "Far Cry 3",
                        ReleaseDate = DateTime.Parse("2011-01-26"),
                        Rate = 3,
                        Price = 45.50M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
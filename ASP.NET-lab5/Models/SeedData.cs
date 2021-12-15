using ASP.NET_lab5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_lab5.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ASPNET_lab5Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ASPNET_lab5Context>>()))
            {
                if (context == null || context.Meal == null)
                {
                    throw new ArgumentNullException("Null ASPNET_lab5Context");
                }

                // Look for any movies.
                if (context.Meal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meal.AddRange(
                    new Meal
                    {
                        Name = "Hamburger",
                        Category = "FastFood",
                        Description = "A hamburger is an extremely popular sandwich consisting of one or more meat patties placed in a bun or a bread roll. The meat is usually accompanied by various ingredients such as tomato slices, onions, pickles, or lettuce, and numerous condiments such as mayonnaise, ketchup, or salsa.",
                        Price = 7.99
                    },

                    new Meal
                    {
                        Name = "Pizza",
                        Category = "FastFood",
                        Description = "pizza, dish of Italian origin consisting of a flattened disk of bread dough topped with some combination of olive oil, oregano, tomato, olives, mozzarella or other cheese, and many other ingredients, baked quickly—usually, in a commercial setting, using a wood-fired oven heated to a very high temperature—and served hot",
                        Price = 42
                    },

                   new Meal
                   {
                       Name = "Spaghetti",
                       Category = "Pasta",
                       Description = "is a long, thin, solid, cylindrical pasta. It is a staple food of traditional Italian cuisine. Like other pasta, spaghetti is made of milled wheat and water and sometimes enriched with vitamins and minerals. Italian spaghetti is typically made from durum wheat semolina.",
                       Price = 12.60
                   },

                    new Meal
                    {
                        Name = "Onion Soup",
                        Category = "Soup",
                        Description = "Warm, cozy, and flavorful, this French onion soup is prepared with beef stock and caramelized onions. Top with croutons covered in melty Gruyere and Parmesan cheese.",
                        Price = 5.99
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

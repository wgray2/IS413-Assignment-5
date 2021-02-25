using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This data is sent to the databse if none is added

namespace IS413_Assignment_5.Models
{
    public class SeedData
    {
        //Create Seed Data for our database in case there isn't any. I used what was on the instructions
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            StoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95f,
                        NumPages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58f,
                        NumPages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54f,
                        NumPages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61f,
                        NumPages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33f,
                        NumPages = 528
,
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95f,
                        NumPages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99f,
                        NumPages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66f,
                        NumPages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16f,
                        NumPages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03f,
                        NumPages = 642
                    },
                    new Book
                    {
                        Title = "Hunger Games",
                        Author = "Suzanne Collins",
                        Publisher = "Scholastic",
                        ISBN = "978-0439023481",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.00f,
                        NumPages = 374
                    },
                    new Book
                    {
                        Title = "Lightning Thief",
                        Author = "Rick Riordan",
                        Publisher = "Miramax",
                        ISBN = "978-0786838653",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 25.23f,
                        NumPages = 377
                    },
                    new Book
                    {
                        Title = "Green Eggs and Ham",
                        Author = "Dr. Seuss",
                        Publisher = "Penguin",
                        ISBN = "978-0394900162",
                        Classification = "Fiction",
                        Category = "Suspense",
                        Price = 5.30f,
                        NumPages = 62
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

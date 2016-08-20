using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eshopy.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EshopyContext>
    {
        protected override void Seed(EshopyContext context)
        {
            var products = new List<Products>
            {
                new Products { Sponsor = "APPLE" },
                new Products { Sponsor = "SAMSUNG" },
                new Products { Sponsor = "LG" },
                new Products { Sponsor = "HP" },
                new Products { Sponsor = "CANNON" },
                new Products { Sponsor = "SHARP" },
                new Products { Sponsor = "PHILIPPS" }
            };

           
            new List<Products>
            {
                new Products { Title = "Iphone 6s", Price = 599.99M, Sponsor = "Apple", Description = "Apple's latest SmartPhone in a CHEAPER price!", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "Samsung Galaxy s7", Price = 499.99M, Sponsor = "Samsung", Description = "Samsung's latest SmartPhone in a CHEAPER price!", AlbumArtUrl = "/Assets/images/placeholder.gif" }
            };
            }
        }
    }

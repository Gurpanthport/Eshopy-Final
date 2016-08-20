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
                new Products { Sponsor = "CANON" },
                new Products { Sponsor = "SHARP" },
                new Products { Sponsor = "Sony" }
            };


            new List<Products>
            {
                new Products { Title = "Iphone 6s", Price = 599.99M, Sponsor = "Apple", Description = "Apple's latest SmartPhone in a CHEAPER price!", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "Samsung Galaxy s7", Price = 499.99M, Sponsor = "Samsung", Description = "Samsung's latest SmartPhone in a CHEAPER price!", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "LG Super UHD 4K Tv", Price = 1599.99M, Sponsor = "LG", Description = "Bring colour to your life with a brilliance of High Definition!", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "HP EliteBook Folio G1", Price = 399.99M, Sponsor = "HP", Description = "The world's thinnest and lightest business-class notebook.", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "CANON EOS 5DS", Price = 299.99M, Sponsor = "CANON", Description = "Perfect for commercial and fine art photography, or any other application that calls for extremely high-resolution, the EOS 5DS is the ultimate combination of EOS performance and ultra-high megapixel capture", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "Sharp 75 CLASS AQUOS 4K SMART TV", Price = 2599.99M, Sponsor = "Sharp", Description = "This big, beautiful 75 inch TV is also big on features. The combination of HDR processing and multi-zone local dimming simply means you get an amazingly realistic image with vibrant color and detail", AlbumArtUrl = "/Assets/images/placeholder.gif" },
                new Products { Title = "Sony XPeria 5z", Price = 199.99M, Sponsor = "Sony", Description = "A revolutionary camera and an innovative design. Meet the smartphone that does picture perfect, every day.", AlbumArtUrl = "/Assets/images/placeholder.gif" }
            };
            }
        }
    }

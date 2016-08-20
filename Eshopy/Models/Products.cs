using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshopy.Models
{
    public class Products
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Products()
        {

        }

        /// <summary>
        /// This constructor takes one paramter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Products(string Name)
        {
            this.Title = Title;
        }

        public virtual int ProductId { get; set; }
        public virtual string Sponsor { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Description { get; set; }
        public virtual string AlbumArtUrl { get; set; }
    
    }
}
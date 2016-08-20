using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshopy.Models
{
    public class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int Count { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Products Product { get; set; }
    }
}
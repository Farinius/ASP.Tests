using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NETTest0001.Models
{
    public class ProductType
    {
        public int ProductTypeID { get; set; }
        [Required]
        [StringLength(255,MinimumLength =1)]
        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
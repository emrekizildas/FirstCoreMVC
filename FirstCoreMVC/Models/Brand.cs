using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstCoreMVC.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}

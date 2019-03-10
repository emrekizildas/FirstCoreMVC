using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCoreMVC.Models
{
    public class Product
    {

        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category{ get; set; }


        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstCoreMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}

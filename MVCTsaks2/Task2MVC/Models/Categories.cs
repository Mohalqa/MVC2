using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Task2MVC.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] Image { get; set; } 
        public ICollection<Product> Products { get; set; }
    }
}

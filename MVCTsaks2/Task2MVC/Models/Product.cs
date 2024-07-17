
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Task2MVC.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

       
        public byte[] Image { get; set; } 

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniFlipkart.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(maximumLength:100)]
        public string Name { get; set; }
    }
}
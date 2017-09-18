using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniFlipkart.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 200)]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage = "Price can not be zero or black")]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public Category Category { get; set; }
    }
}
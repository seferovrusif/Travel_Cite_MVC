﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Sinaq.Models
{
    public class Destination
    {
        public int Id{ get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public float Price { get; set; }
        [Required,Range(0,5)]
        public float Rate { get; set; }

    }
}

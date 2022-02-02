﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{
  
    public class Container
    {
        [Required]
        public int containerId { get; set; }

        [Required]
        public int productId { get; set; }

        [Required]
        public int uomId { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public int locationId { get; set; }
        
        public int weight { get; set; }

        [Required]
        public DateTime creationDate { get; set; }

    }
}

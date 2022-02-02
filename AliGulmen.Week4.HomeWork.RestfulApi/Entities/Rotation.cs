﻿using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{

    /*
     * Rotation : Measure of the number of times inventory is sold or used in a time period such as a year.  
     * In this project, Rotation will be used to determine where containers should be placed in the warehouse.
     * Category A, Category B, Category C (CatA > Cat B > Cat C)
     * Cat A products should be placed easier places to reach which means Cat C products might be at the last position of warehouse
    */
    public class Rotation
    {
        [Required]
        public int rotationId { get; set; }

        [Required]
        public string rotationCode { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{
    
    public class Location
    {
        [Required]
        public int locationId { get; set; }

        [Required]
        public string locationName { get; set; }

        public int rotationId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{

   
    public class Rotation
    {
        [Required]
        public int rotationId { get; set; }

        [Required]
        public string rotationCode { get; set; }
    }
}

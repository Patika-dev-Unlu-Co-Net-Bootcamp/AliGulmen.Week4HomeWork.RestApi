using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{
  
    public class Uom
    {
        [Required]
        public int uomId { get; set; }

        [Required]
        public string uomCode { get; set; }
        public string description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Entities
{
	
	public class Product
	{
		[Required]
		public int productId { get; set; }

		[Required]
		public string productCode { get; set; }

		public string description { get; set; }
		public int rotationId { get; set; }

		[Required]
		public bool isActive { get; set; }

		public int lifeTime { get; set; }

	}
}

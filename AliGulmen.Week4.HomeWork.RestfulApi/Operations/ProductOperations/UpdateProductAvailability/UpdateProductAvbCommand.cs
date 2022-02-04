using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.UpdateProductAvailability
{
    public class UpdateProductAvbCommand
    {
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        private static List<Product> ProductList = DataGenerator.ProductList;


        public UpdateProductAvbCommand()
        {

        }

        public void Handle()
        {

            var product = ProductList.SingleOrDefault(p => p.Id == ProductId); 
            if (product is null)
                throw new InvalidOperationException("Product is not found!");


            product.IsActive = IsActive != default ? IsActive : product.IsActive;


        }
    }
}

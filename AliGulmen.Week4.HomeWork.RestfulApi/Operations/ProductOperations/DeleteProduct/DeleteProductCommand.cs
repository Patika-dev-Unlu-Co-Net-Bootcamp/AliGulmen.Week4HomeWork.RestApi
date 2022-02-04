using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.DeleteProduct
{
    public class DeleteProductCommand
    {
        public int ProductId { get; set; }
        private static List<Product> ProductList = DataGenerator.ProductList;

        public DeleteProductCommand()
        {

        }



        public void Handle()
        {

            var ourRecord = ProductList.SingleOrDefault(p => p.Id == ProductId); 
            if (ourRecord is null)
                throw new InvalidOperationException("There is no record to delete!");

            ProductList.Remove(ourRecord);

        }
    }
}

using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.CreateProduct
{
    public class CreateProductCommand
    {
        public Product Model { get; set; }
        private static List<Product> ProductList = DataGenerator.ProductList;

        public CreateProductCommand()
        {

        }


        public void Handle()
        {

            if (Model == null)
                throw new InvalidOperationException("No data entered!");

            var product = ProductList.SingleOrDefault(p => p.productId == Model.productId); 

            if (product is not null)
                throw new InvalidOperationException("You already have this productCode in your list!");

            product = Model;
            ProductList.Add(product);

        }
    }
}

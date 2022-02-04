using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.UpdateProduct
{
    public class UpdateProductCommand
    {
        public int ProductId { get; set; }
        public Product Model { get; set; }
        private static List<Product> ProductList = DataGenerator.ProductList;


        public UpdateProductCommand()
        {

        }

        public void Handle()
        {
            if (Model is null)
                throw new InvalidOperationException("No data entered!");


            var product = ProductList.SingleOrDefault(u => u.Id == ProductId); 
            if (product is null)
                throw new InvalidOperationException("Product is not found!");


           
            product.Id = Model.Id != default ? Model.Id : product.Id;
            product.ProductCode = Model.ProductCode != default ? Model.ProductCode : product.ProductCode;
            product.Description = Model.Description != default ? Model.Description : product.Description;
            product.Rotation.Id = Model.Rotation.Id != default ? Model.Rotation.Id : product.Rotation.Id;
            product.IsActive = Model.IsActive != default ? Model.IsActive : product.IsActive;
            product.LifeTime = Model.LifeTime != default ? Model.LifeTime : product.LifeTime;


        }
    }
}

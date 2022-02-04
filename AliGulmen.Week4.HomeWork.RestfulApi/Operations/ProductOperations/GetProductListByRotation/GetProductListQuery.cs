using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.GetProductListByRotation
{
    public class GetProductListQuery
    {
        private static List<Product> ProductList = DataGenerator.ProductList;
        public int RotationId { get; set; } 

        public GetProductListQuery()
        {

        }

        public List<Product> Handle()
        {
              var products = ProductList.Where(b => b.Rotation.Id == RotationId).ToList();
            if (products is null)
                throw new InvalidOperationException("The product is not exist!");


            return products;



        }
    }
}

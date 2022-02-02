using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.GetProductDetail
{
    public class GetProductDetailQuery
    {
        private static List<Product> ProductList = DataGenerator.ProductList;
        public int ProductId { get; set; } 

        public GetProductDetailQuery()
        {

        }

        public Product Handle()
        {
            var product = ProductList.Where(p => p.productId == ProductId).SingleOrDefault();
            if (product is null)
                throw new InvalidOperationException("The product is not exist!");


            return product;



        }
    }
}

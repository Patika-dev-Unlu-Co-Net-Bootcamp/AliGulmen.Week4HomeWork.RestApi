using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ProductOperations.GetProductContainers
{
    public class GetProductContainersQuery
    {
        private static List<Container> ContainerList = DataGenerator.ContainerList;

        public int ProductId { get; set; } 

        public GetProductContainersQuery()
        {

        }

        public List<Container> Handle()
        {

            var containers = ContainerList.Where(c => c.Product.Id == ProductId).ToList();
            if (containers.Count == 0)
                throw new InvalidOperationException("There is no container defined with this product");

            return containers;



        }
    }
}

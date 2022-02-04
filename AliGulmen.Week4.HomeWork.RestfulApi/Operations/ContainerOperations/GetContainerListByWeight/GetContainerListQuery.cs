using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.GetContainerListByWeight
{
    public class GetContainerListQuery
    {

        private static List<Container> ContainerList = DataGenerator.ContainerList;
        public int MaxWeight { get; set; } 

        public GetContainerListQuery()
        {

        }

        public List<Container> Handle()
        {
            var containers = ContainerList
                                    .Where(container => container.Weight <= MaxWeight)
                                    .OrderBy(container => container.Weight)
                                    .ToList();
            if (containers is null)
                throw new InvalidOperationException("The container is not exist!");


            return containers;

        }
    }
}

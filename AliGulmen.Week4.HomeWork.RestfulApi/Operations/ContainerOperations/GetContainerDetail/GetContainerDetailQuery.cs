using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.GetContainerDetail
{
    public class GetContainerDetailQuery
    {
        private static List<Container> ContainerList = DataGenerator.ContainerList;
        public int ContainerId { get; set; } //the id which will come from outside

        public GetContainerDetailQuery()
        {

        }

        public Container Handle()
        {
            var container = ContainerList.Where(container => container.Id == ContainerId).SingleOrDefault();
            if (container is null)
                throw new InvalidOperationException("The container is not exist!");


            return container;

        }
    }
}

using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.DeleteContainer
{
    public class DeleteContainerCommand
    {
        public int ContainerId { get; set; }
        private static List<Container> ContainerList = DataGenerator.ContainerList;

        public DeleteContainerCommand()
        {

        }



        public void Handle()
        {

            var ourRecord = ContainerList.SingleOrDefault(c => c.containerId == ContainerId); //is it exist?
            if (ourRecord is null)
                throw new InvalidOperationException("There is no record to delete!");

            ContainerList.Remove(ourRecord);

        }
    }
}

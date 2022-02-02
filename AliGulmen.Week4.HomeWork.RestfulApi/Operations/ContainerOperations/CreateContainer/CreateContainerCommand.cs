using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.CreateContainer
{
    public class CreateContainerCommand
    {
        public Container Model { get; set; }
        private static List<Container> ContainerList = DataGenerator.ContainerList;

        public CreateContainerCommand()
        {

        }


        public void Handle()
        {

            if (Model == null)
                throw new InvalidOperationException("No data entered!");

            var container = ContainerList.SingleOrDefault(c => c.containerId == Model.containerId); 

            if (container is not null) 
                throw new InvalidOperationException("You already have this container in your list!");

            container = Model;
            ContainerList.Add(container);

        }
    }
}

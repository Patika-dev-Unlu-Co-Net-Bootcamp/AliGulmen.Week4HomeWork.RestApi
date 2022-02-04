using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.CreateLocation
{
    public class CreateLocationCommand
    {
        public Location Model { get; set; }
        private static List<Location> LocationList = DataGenerator.LocationList;

        public CreateLocationCommand()
        {

        }


        public void Handle()
        {

            if (Model == null)
                throw new InvalidOperationException("No data entered!");

            var location = LocationList.SingleOrDefault(u => u.Id == Model.Id);

            if (location is not null) 
                throw new InvalidOperationException("You already have this locationCode in your list!");

            location = Model;
            LocationList.Add(location);

        }
    }
}

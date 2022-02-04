using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.UpdateLocation
{
    public class UpdateLocationCommand
    {
        public int LocationId { get; set; }
        public Location Model { get; set; }
        private static List<Location> LocationList = DataGenerator.LocationList;


        public UpdateLocationCommand()
        {

        }

        public void Handle()
        {
            if (Model is null)
                throw new InvalidOperationException("No data entered!");


            var location = LocationList.SingleOrDefault(loc => loc.Id == LocationId); 
            if (location is null)
                throw new InvalidOperationException("Location is not found!");



            location.Id = Model.Id != default ? Model.Id : location.Id;
            location.LocationName = Model.LocationName != default ? Model.LocationName : location.LocationName;
            location.RotationId = Model.RotationId != default ? Model.RotationId : location.RotationId;
           

        }
    }
}

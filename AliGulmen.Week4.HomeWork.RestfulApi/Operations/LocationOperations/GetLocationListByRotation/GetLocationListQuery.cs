﻿using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.GetLocationListByRotation
{
    public class GetLocationListQuery
    {
        private static List<Location> LocationList = DataGenerator.LocationList;
        public int RotationId { get; set; } 

        public GetLocationListQuery()
        {

        }

        public List<Location> Handle()
        {
            var locations = LocationList.Where(l => l.rotationId == RotationId).ToList();
            if (locations is null)
                throw new InvalidOperationException("The location is not exist!");


            return locations;



        }
    }
}

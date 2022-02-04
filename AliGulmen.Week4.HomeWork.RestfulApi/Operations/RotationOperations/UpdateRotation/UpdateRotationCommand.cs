using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.UpdateRotation
{
    public class UpdateRotationCommand
    {
        public int RotationId { get; set; }
        public Rotation Model { get; set; }
        private static List<Rotation> RotationList = DataGenerator.RotationList;


        public UpdateRotationCommand()
        {

        }

        public void Handle()
        {
            if (Model is null)
                throw new InvalidOperationException("No data entered!");


            var rotation = RotationList.SingleOrDefault(u => u.Id == RotationId); 
            if (rotation is null)
                throw new InvalidOperationException("Rotation is not found!");


            rotation.Id = Model.Id != default ? Model.Id : rotation.Id;
            rotation.RotationCode = Model.RotationCode != default ? Model.RotationCode : rotation.RotationCode;
           


        }
    }
}

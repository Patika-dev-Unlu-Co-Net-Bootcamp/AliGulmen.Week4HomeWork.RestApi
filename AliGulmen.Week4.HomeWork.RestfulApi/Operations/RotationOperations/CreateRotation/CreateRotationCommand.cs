using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.CreateRotation
{
    public class CreateRotationCommand
    {
        public Rotation Model { get; set; }
        private static List<Rotation> RotationList = DataGenerator.RotationList;

        public CreateRotationCommand()
        {

        }


        public void Handle()
        {

            if (Model == null)
                throw new InvalidOperationException("No data entered!");

            var rotation = RotationList.SingleOrDefault(u => u.rotationCode == Model.rotationCode); 

            if (rotation is not null)
                throw new InvalidOperationException("You already have this rotation in your list!");

            rotation = Model;
            RotationList.Add(rotation);

        }
    }
}

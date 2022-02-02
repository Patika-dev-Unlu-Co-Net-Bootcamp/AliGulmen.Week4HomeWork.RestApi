using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.RotationOperations.DeleteRotation
{
    public class DeleteRotationCommand
    {
        public int RotationId { get; set; }
        private static List<Rotation> RotationList = DataGenerator.RotationList;

        public DeleteRotationCommand()
        {

        }



        public void Handle()
        {

            var ourRecord = RotationList.SingleOrDefault(b => b.rotationId == RotationId); //is it exist?
            if (ourRecord is null)
                throw new InvalidOperationException("There is no record to delete!");

            RotationList.Remove(ourRecord);

        }
    }
}

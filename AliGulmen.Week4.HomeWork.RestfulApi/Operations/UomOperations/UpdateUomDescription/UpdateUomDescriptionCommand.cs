using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.UpdateUomDescription
{
    public class UpdateUomDescriptionCommand
    {
        public int UomId { get; set; }
        public string Description { get; set; }
        private static List<Uom> UomList = DataGenerator.UomList;


        public UpdateUomDescriptionCommand()
        {

        }

        public void Handle()
        {
           
            var uom = UomList.SingleOrDefault(u => u.Id == UomId); 
            if (uom is null)
                throw new InvalidOperationException("Uom is not found!");


            uom.Description = Description != default ? Description : uom.Description;


        }
    }
}

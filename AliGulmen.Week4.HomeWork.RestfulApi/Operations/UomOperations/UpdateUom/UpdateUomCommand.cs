using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.UpdateUom
{
    public class UpdateUomCommand
    {
        public int UomId { get; set; }
        public Uom Model { get; set; }
        private static List<Uom> UomList = DataGenerator.UomList;


        public UpdateUomCommand()
        {

        }

        public void Handle()
        {
            if (Model is null)
                throw new InvalidOperationException("No data entered!");


            var uom = UomList.SingleOrDefault(u => u.Id == UomId); 
            if (uom is null)
                throw new InvalidOperationException("Uom is not found!");


            uom.Id = Model.Id != default ? Model.Id : uom.Id;
            uom.UomCode = Model.UomCode != default ? Model.UomCode : uom.UomCode;
            uom.Description = Model.Description != default ? Model.Description : uom.Description;


        }
    }
}

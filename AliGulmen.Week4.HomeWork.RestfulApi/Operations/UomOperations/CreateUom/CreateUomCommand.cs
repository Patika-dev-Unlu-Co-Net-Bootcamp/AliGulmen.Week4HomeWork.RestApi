using AliGulmen.Week4.HomeWork.RestfulApi.DbOperations;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Operations.UomOperations.CreateUom
{
    public class CreateUomCommand
    {
        public Uom Model { get; set; }
        private static List<Uom> UomList = DataGenerator.UomList;

        public CreateUomCommand()
        {

        }


        public void Handle()
        {
           
            if (Model == null) 
                throw new InvalidOperationException("No data entered!");

             var uom = UomList.SingleOrDefault(u => u.Id == Model.Id); 

            if (uom is not null) 
                throw new InvalidOperationException("You already have this uomCode in your list!");

            uom = Model;
            UomList.Add(uom);

        }
    }



}

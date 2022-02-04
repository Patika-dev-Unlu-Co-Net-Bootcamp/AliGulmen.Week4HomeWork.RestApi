using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using System;
using System.Collections.Generic;

namespace AliGulmen.Week4.HomeWork.RestfulApi.DbOperations
{

   
    public class DataGenerator
    {


      
        public static List<Uom> UomList = new List<Uom>() {
            //new Uom { Id = 1, UomCode = "Pk", Description = "Package" },
            //new Uom { Id = 2, UomCode = "Pc", Description = "Piece" },
            //new Uom { Id = 3, UomCode = "Box", Description = "Box" },
            //new Uom { Id = 4, UomCode = "Ctn", Description = "Carton" }
           
        };




        /*
         * Category A, Category B, Category C (CatA > Cat B > Cat C)
         */
        public static List<Rotation> RotationList = new List<Rotation>() {
            //new Rotation { Id = 1, RotationCode = "Cat A"},
            //new Rotation { Id = 2, RotationCode = "Cat B" },
            //new Rotation { Id = 3, RotationCode = "Cat C" },
            //new Rotation { Id = 4, RotationCode = "Cat D" }
        };



        /*
         * locationName =  xxyyzz 
        * xx = side (left=01, right=02)
        * yy = vertical cell (floor)
        * zz = horizontal cell (slot) */

        public static List<Location> LocationList = new List<Location>() {
            //new Location { Id = 1, LocationName = "DockArea", RotationId = 1 },
            //new Location { Id = 2, LocationName = "010102", RotationId = 2 },
            //new Location { Id = 3, LocationName = "010103", RotationId = 3 },
            //new Location { Id = 4, LocationName = "010201", RotationId = 1 },
            //new Location { Id = 5, LocationName = "010202", RotationId = 2 },
            //new Location { Id = 6, LocationName = "010203", RotationId = 3 },
            //new Location { Id = 7, LocationName = "020101", RotationId = 1 },
            //new Location { Id = 8, LocationName = "020102", RotationId = 2 },
            //new Location { Id = 9, LocationName = "020103", RotationId = 3 },
            //new Location { Id = 10, LocationName = "020201", RotationId = 1 },
            //new Location { Id = 11, LocationName = "020202", RotationId = 2 },
            //new Location { Id = 12, LocationName = "020203", RotationId = 3 }, 
           
        };



       
        public static List<Product> ProductList = new List<Product>() {
            //new Product { Id = 1, ProductCode = "87965493291", Description = "Prod1",RotationId = 1,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 2, ProductCode = "87965493292", Description = "Prod2",RotationId = 1,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 3, ProductCode = "87965493293", Description = "Prod3",RotationId = 1,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 4, ProductCode = "87965493294", Description = "Prod4",RotationId = 2,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 5, ProductCode = "87965493295", Description = "Prod5",RotationId = 2,IsActive =false ,LifeTime = 365 },
            //new Product { Id = 6, ProductCode = "87965493296", Description = "Prod6",RotationId = 2,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 7, ProductCode = "87965493297", Description = "Prod7",RotationId = 3,IsActive =true ,LifeTime = 365 },
            //new Product { Id = 8, ProductCode = "87965493298", Description = "Prod8",RotationId = 4,IsActive =true ,LifeTime = 365 }

        };



      
        public static List<Container> ContainerList = new List<Container>() {
            //new Container { Id = 1, ProductId = 1, UomId = 1,Quantity = 200,LocationId =1 ,Weight = 300, CreationDate=DateTime.Today.AddDays(-100) },
            //new Container { Id = 2, ProductId = 1, UomId = 1,Quantity = 100,LocationId =5 ,Weight = 250, CreationDate=DateTime.Today.AddDays(-45) },
            //new Container { Id = 3, ProductId = 3, UomId = 2,Quantity = 150,LocationId =3 ,Weight = 400, CreationDate=DateTime.Today.AddDays(-15) },
            //new Container { Id = 4, ProductId = 4, UomId = 2,Quantity = 150,LocationId =6 ,Weight = 300, CreationDate=DateTime.Today.AddDays(-1) },
            //new Container { Id = 5, ProductId = 4, UomId = 2,Quantity = 150,LocationId =7 ,Weight = 300, CreationDate=DateTime.Today.AddDays(-97) },
            //new Container { Id = 6, ProductId = 6, UomId = 2,Quantity = 240,LocationId =8 ,Weight = 240, CreationDate=DateTime.Today.AddDays(-16) },
            //new Container { Id = 7, ProductId = 7, UomId = 2,Quantity = 300,LocationId =11 ,Weight = 500, CreationDate=DateTime.Today.AddDays(-16) },
            //new Container { Id = 8, ProductId = 8, UomId = 3,Quantity = 140,LocationId =9 ,Weight = 250, CreationDate=DateTime.Today.AddDays(-78) }

        };


      
        public static List<Stock> StockList = new List<Stock>() {
            //new Stock { ProductId = 1, ReadyToShip = 12, StockOnRack = 145},
            //new Stock { ProductId = 2, ReadyToShip = 55, StockOnRack = 425},
            //new Stock { ProductId = 3, ReadyToShip = 47, StockOnRack = 123},
            //new Stock { ProductId = 4, ReadyToShip = 34, StockOnRack = 262},
            //new Stock { ProductId = 5, ReadyToShip = 23, StockOnRack = 190},
            //new Stock { ProductId = 6, ReadyToShip = 17, StockOnRack = 43},
            //new Stock { ProductId = 7, ReadyToShip = 0, StockOnRack = 0},
            //new Stock { ProductId = 8, ReadyToShip = 23, StockOnRack = 21}
           

        };

    }
}

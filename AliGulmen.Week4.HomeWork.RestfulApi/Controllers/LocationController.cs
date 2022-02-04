using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using Microsoft.AspNetCore.Mvc;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.GetLocations;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.GetLocationDetail;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.GetLocationListByRotation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.CreateLocation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.UpdateLocation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.DeleteLocation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.LocationOperations.UpdateLocationRotation;
using Microsoft.AspNetCore.Authorization;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Authorize]
    [Route("api/[controller]s")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        public LocationController()
        { }

        /************************************* GET *********************************************/

        //GET api/locations
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetLocations()
        {
            var query = new GetLocationsQuery();
            var result = query.Handle();
            return Ok(result);
        }

        //GET api/locations/1
        [HttpGet("{id}")]
        public IActionResult LocationById(int id)
        {
            var query = new GetLocationDetailQuery();
            query.LocationId = id;

            var result = query.Handle();
            return Ok(result);
        }

        //GET api/products/list?rotationId=1
        [HttpGet("list")]
        public IActionResult GetProductsByRotation([FromQuery] int rotationId)
        {

            var query = new GetLocationListQuery();
            query.RotationId = rotationId;

            var result = query.Handle();
            return Ok(result);
        }




        /************************************* POST *********************************************/



        //POST api/locations
        [HttpPost]
        public IActionResult CreateLocation([FromBody] Location newLocation)
        {

            var command = new CreateLocationCommand();
            command.Model = newLocation;
            command.Handle();
            return Created("~api/locations", newLocation); 
        }



        /************************************* PUT *********************************************/


        //PUT api/locations/id
        [HttpPut("{id}")]
        public IActionResult Update(int id, Location newLocation)
        {

            var command = new UpdateLocationCommand();
            command.LocationId = id;
            command.Model = newLocation;


            command.Handle();
            return NoContent(); 

        }


        /************************************* DELETE *********************************************/

        //DELETE api/locations/id
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var command = new DeleteLocationCommand();
            command.LocationId = id;
            command.Handle();
            return NoContent(); 
        }



        /************************************* PATCH *********************************************/

        //PATCH api/locations/id
        [HttpPatch("{id}")]
        public IActionResult UpdateRotation(int id, int rotationId)
        {
            var command = new UpdateLocationRotationCommand();
            command.LocationId = id;
            command.RotationId = rotationId;


            command.Handle();
            return NoContent(); 


        }
    }
}

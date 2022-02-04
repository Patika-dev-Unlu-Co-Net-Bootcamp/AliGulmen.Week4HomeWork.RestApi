using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using Microsoft.AspNetCore.Mvc;
using AliGulmen.Week4.HomeWork.RestfulApi.Services.StorageService;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.GetContainers;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.GetContainerDetail;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.CreateContainer;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.UpdateContainer;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.DeleteContainer;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.UpdateContainerLocation;
using AliGulmen.Week4.HomeWork.RestfulApi.Operations.ContainerOperations.GetContainerListByWeight;
using Microsoft.AspNetCore.Authorization;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Authorize]
    [Route("api/[controller]s")]
    [ApiController]
    public class ContainerController : ControllerBase

    {

         private readonly IStorageService _storageService;


        public ContainerController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        /************************************* GET *********************************************/

        //GET api/containers
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetContainers()
        {
            var query = new GetContainersQuery();
            var result = query.Handle();
            return Ok(result);
        }

        //GET api/containers/1
        [HttpGet("{id}")]
        public IActionResult GetContainerById(int id)
        {
            var query = new GetContainerDetailQuery();
            query.ContainerId = id;

            var result = query.Handle();
            return Ok(result);
        }


       
        //GET api/products/list?maxWeight=100
        [HttpGet("list")]
        public IActionResult GetContainersByMaxWeight([FromQuery] int maxWeight)
        {

            var query = new GetContainerListQuery();
            query.MaxWeight = maxWeight;

            var result = query.Handle();
            return Ok(result);
        }




        /************************************* POST *********************************************/



        //POST api/containers
        [HttpPost]
        public IActionResult CreateContainer([FromBody] Container newContainer)
        {
            var command = new CreateContainerCommand();
            command.Model = newContainer;
            command.Handle();

            return Created("~api/containers", newContainer);
        }



        /************************************* PUT *********************************************/


        //PUT api/containers/id
        [HttpPut("{id}")]
        public IActionResult Update(int id,Container newContainer)
        {
            var command = new UpdateContainerCommand();
            command.ContainerId = id;
            command.Model = newContainer;


            command.Handle();

            return NoContent(); 

        }


        /************************************* DELETE *********************************************/

        //DELETE api/rotations/id
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var command = new DeleteContainerCommand();
            command.ContainerId = id;
            command.Handle();

            return NoContent(); 
        }



        /************************************* PATCH *********************************************/


        [HttpPatch("{id}")]
        public IActionResult UpdateLocation(int id, int locationId)
        {
            var command = new UpdateContainerLocationCommand();
            command.ContainerId = id;
            command.LocationId = locationId;


            command.Handle();

            return NoContent(); 


        }
    }
}

using BLHazinu;
using DTOHazinu.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hazinu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskBL _ITaskBL;
        public TaskController(ITaskBL e)
        {
            _ITaskBL = e;
        }

        [HttpGet]
        [Route("GetAllTasks")]
        public List<TaskDTO> GetAllTasks()
        {
            return _ITaskBL.GetAllTask();
        }


        [HttpPost]
        [Route("AddTask")]
        public IActionResult AddTask([FromBody] TaskDTO u)
        {
            try
            {
                return Ok(_ITaskBL.AddTask(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatTask/{id}")]
        public IActionResult DeleatTask( string id)
        {
            try
            {
                return Ok(_ITaskBL.DeleteTask(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateTask/{id}")]
        public IActionResult UpdateUser(string id, TaskDTO u)
        {
            try
            {
                return Ok(_ITaskBL.UpdateTask(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}

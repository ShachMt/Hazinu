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
        public bool AddTask([FromBody] TaskDTO u)
        {
            return _ITaskBL.AddTask(u);
        }

        [HttpDelete]
        [Route("DeleatTask")]
        public bool DeleatTask([FromBody] string id)
        {
            return _ITaskBL.DeleteTask(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateTask")]
        public bool UpdateUser(string id, TaskDTO u)
        {
            return _ITaskBL.UpdateTask(int.Parse(id), u);
        }

    }
}

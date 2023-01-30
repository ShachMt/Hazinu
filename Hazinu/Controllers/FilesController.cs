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
    public class FilesController : ControllerBase
    {
         private IFilesBL _IFilessBL;
        public FilesController(IFilesBL e)
        {
            _IFilessBL = e;
        }

        [HttpGet]
        [Route("GetAllFiles")]
        public List<FilesDTO> GetAllFiles()
        {
            return _IFilessBL.GetAllFiles();
        }

        [HttpPost]
        [Route("AddFiles")]
        public IActionResult AddJob([FromBody] FilesDTO s)
        {
            try
            {
                return Ok(_IFilessBL.AddFiles(s));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpDelete]
        [Route("DeleatFiles/{id}")]
        public IActionResult DeleatJobs(string id)
        {
            try
            {
                return Ok(_IFilessBL.DeleatFiles(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
      
        [HttpPut]
        [Route("UpdateFiles/{id}")]
        public IActionResult UpdateJobs(string id, FilesDTO u)
        {
            try
            {
                return Ok(_IFilessBL.UpdateFiles(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}

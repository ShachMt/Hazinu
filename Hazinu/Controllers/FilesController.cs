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
        public bool AddFiles([FromBody] FilesDTO u)
        {
            return _IFilessBL.AddFiles(u);
        }

        [HttpDelete]
        [Route("DeleatFiles")]
        public bool DeleatFiles([FromBody] string id)
        {
            return _IFilessBL.DeleatFiles(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateFiles")]
        public bool UpdateUser(string id, FilesDTO u)
        {
            return _IFilessBL.UpdateFiles(int.Parse(id), u);
        }
    }
}

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
    public class EducationalInstitutionController : ControllerBase
    {
        private IEducationalInstitutionBL _IEducationalInstitutionBL;
        public EducationalInstitutionController(IEducationalInstitutionBL e)
        {
            _IEducationalInstitutionBL = e;
        }

        [HttpGet]
        [Route("GetAllEducationalInstitution")]
        public List<EducationalInstitutionDTO> GetEducationalInstitution()
        {
            return _IEducationalInstitutionBL.GetAllEducationalInstitution();
        }
        [HttpGet]
        [Route("GetAllInstitutionsCategoriesByGender/{idCategory}")]

        public IActionResult GetAllInstitutionsCategoriesByGender(string idCategory)
        {
            try
            {
                return Ok(_IEducationalInstitutionBL.GetAllInstitutionsCategories(int.Parse(idCategory)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet]
        [Route("GetAllInstitutionsCategoriesByGenderCity/{idCategory}/{city}")]

        public IActionResult GetAllInstitutionsCategoriesByGenderCity(string idCategory, string city)
        {
            try
            {
                return Ok(_IEducationalInstitutionBL.GetAllInstitutionsCategoriesByGenderCity(int.Parse(idCategory), city));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPost]
        [Route("AddEducationalInstitution")]
        public IActionResult AddEducationalInstitution([FromBody] EducationalInstitutionDTO e)
        {
            try
            {
                return Ok(_IEducationalInstitutionBL.AddEducationalInstitution(e));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteEducationalInstitution/{id}")]
        public IActionResult DeleteEducationalInstitution(string id)
        {
            try
            {
                return Ok(_IEducationalInstitutionBL.DeleteEducationalInstitution(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
            [HttpPut]
            [Route("UpdateEducationalInstitution/{id}")]

            public IActionResult UpdateEducationalInstitution(string id, EducationalInstitutionDTO u)
            {
                try
                {
                    return Ok(_IEducationalInstitutionBL.UpdateEducationalInstitution(int.Parse(id), u));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

        } } 


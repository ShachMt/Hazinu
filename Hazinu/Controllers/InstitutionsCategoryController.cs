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
    public class InstitutionsCategoryController : ControllerBase
    {
            private IInstitutionsCategoryBL _IInstitutionsBL;
            public InstitutionsCategoryController(IInstitutionsCategoryBL e)
            {
                _IInstitutionsBL = e;
            }

            //סיווג קטגוריות מוסדות לימוד לפי מין
            [HttpGet]
            [Route("GetAllInstitutionsCategoriesByGenderAndAge/{gender}/{age}")]
            public List<InstitutionsCategoryDTO> GetAllInstitutionsCategoriesByGender(string gender,string age)
            {
                return _IInstitutionsBL.GetAllInstitutionsCategoriesByGender(gender,int.Parse(age));
            }

            //החזרת כל הקטגוריות
            [HttpGet]
            [Route("GetAllInstitutionsCategories")]
            public List<InstitutionsCategoryDTO> GetAllInstitutionsCategories()
            {
                return _IInstitutionsBL.GetAllInstitutionsCategories();
            }
            //הוספת קטגוריית מוסד לימוד
            [HttpPost]
            [Route("AddInstitutionsCategory")]
        public IActionResult AddInstitutionsCategory( InstitutionsCategoryDTO u)
        {
            try
            {
                return Ok(_IInstitutionsBL.AddInstitutionsCategory(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
            [HttpDelete]
            [Route("DeleatInstitutionsCategory/{id}")]
        //מחיקת קטגוריה
        public IActionResult DeleteInstitutionsCategory(string id)
        {
            try
            {
                return Ok(_IInstitutionsBL.DeleteInstitutionsCategory(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        //ועדכון קטגוריה

        [HttpPut]
        [Route("UpdateInstitutionsCategory/{id}")]
        public IActionResult UpdateInstitutionsCategory(string id, InstitutionsCategoryDTO u)
        {
            try
            {
                return Ok(_IInstitutionsBL.UpdateInstitutionsCategory(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       

        }
    }


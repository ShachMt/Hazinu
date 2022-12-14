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
            [Route("GetAllInstitutionsCategoriesByGenderAndAge")]
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
            public bool AddInstitutionsCategory([FromBody] InstitutionsCategoryDTO u)
            {
                return _IInstitutionsBL.AddInstitutionsCategory(u);
            }
            [HttpDelete]
            [Route("DeleatInstitutionsCategory")]
            //מחיקת קטגוריה
            public bool DeleteInstitutionsCategory([FromBody] string id)
            {
                return _IInstitutionsBL.DeleteInstitutionsCategory(int.Parse(id));

            }
            [HttpPut]
            [Route("UpdateInstitutionsCategory/{id}")]
            //ועדכון קטגוריה
            public bool UpdateInstitutionsCategory(string id, [FromBody] InstitutionsCategoryDTO u)
            {
                return _IInstitutionsBL.UpdateInstitutionsCategory(int.Parse(id), u);

            }

        }
    }


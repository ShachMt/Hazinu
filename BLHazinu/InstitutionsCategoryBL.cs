using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
    public class InstitutionsCategoryBL : IInstitutionsCategoryBL
    {
        IMapper mapper;
        public InstitutionsCategoryBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        InstitutionsCategoryDL _InstitutionsCategoryDL = new InstitutionsCategoryDL();

        //סיווג קטגוריות מוסדות לימוד לפי מין
        public List<InstitutionsCategoryDTO> GetAllInstitutionsCategoriesByGender(string gender, int age)
        {
            List<InstitutionsCategory> listInstitutionsCategory = _InstitutionsCategoryDL.GetAllInstitutionsCategoriesByGender(gender,age);
            return mapper.Map<List<InstitutionsCategory>, List<InstitutionsCategoryDTO>>(listInstitutionsCategory);
        }

        //החזרת כל הקטגוריות
        public List<InstitutionsCategoryDTO> GetAllInstitutionsCategories()
        {
            List<InstitutionsCategory> listInstitutionsCategory = _InstitutionsCategoryDL.GetAllInstitutionsCategories();
            return mapper.Map<List<InstitutionsCategory>, List<InstitutionsCategoryDTO>>(listInstitutionsCategory);
        }
        public List<InstitutionsCategoryDTO> GetAllInstitutionsCategoriesByAgeGange(int id)
        {
            List<InstitutionsCategory> listInstitutionsCategory = _InstitutionsCategoryDL.GetAllInstitutionsCategoriesByAgeGange(id);
            return mapper.Map<List<InstitutionsCategory>, List<InstitutionsCategoryDTO>>(listInstitutionsCategory);
        }

        //הוספת קטגוריית מוסד לימוד
        public int AddInstitutionsCategory(InstitutionsCategoryDTO u)
        {
            return _InstitutionsCategoryDL.AddInstitutionsCategory(mapper.Map<InstitutionsCategoryDTO, InstitutionsCategory>(u));
        }

        //מחיקת קטגוריה
        public bool DeleteInstitutionsCategory(int id)
        {
            return _InstitutionsCategoryDL.DeleteInstitutionsCategory(id);

        }
        //ועדכון קטגוריה
        public bool UpdateInstitutionsCategory(int id, InstitutionsCategoryDTO u)
        {
            return _InstitutionsCategoryDL.UpdateInstitutionsCategory(id, mapper.Map<InstitutionsCategoryDTO, InstitutionsCategory>(u));

        }


    }
}

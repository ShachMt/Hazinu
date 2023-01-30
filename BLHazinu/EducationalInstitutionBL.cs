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
    public class EducationalInstitutionBL : IEducationalInstitutionBL
    {
        IMapper mapper;
        public EducationalInstitutionBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        EducationalInstitutionDL _EducationalInstitutionDL = new EducationalInstitutionDL();

        public List<EducationalInstitutionDTO> GetAllEducationalInstitution()
        {
            List<EducationalInstitution> AllEducationalInstitution = _EducationalInstitutionDL.GetAllEducationalInstitution();
            return mapper.Map<List<EducationalInstitution>, List<EducationalInstitutionDTO>>(AllEducationalInstitution);
        }

        //החזרת מוסדות לימוד לפי לפי טווח גילאים וגיל
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategories(int idCadegory)
        {
            List<EducationalInstitution> AllEducationalInstitution = _EducationalInstitutionDL.GetAllInstitutionsCategories(idCadegory);
            return mapper.Map<List<EducationalInstitution>, List<EducationalInstitutionDTO>>(AllEducationalInstitution);
        }
        //בשביל המילוי מוסד לימודים חדש
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGenderCity(int idCategory, string city)
        {
            List<EducationalInstitution> AllEducationalInstitution = _EducationalInstitutionDL.GetAllInstitutionsCategoriesByGenderCity(idCategory, city);
            return mapper.Map<List<EducationalInstitution>, List<EducationalInstitutionDTO>>(AllEducationalInstitution);
    }
        public bool DeleteEducationalInstitution(int id)
        {
            return _EducationalInstitutionDL.DeleteEducationalInstitution(id);
        }
        public int AddEducationalInstitution(EducationalInstitutionDTO u)
        {
            return _EducationalInstitutionDL.AddEducationalInstitution(mapper.Map<EducationalInstitutionDTO, EducationalInstitution>(u));
        }
        public bool UpdateEducationalInstitution(int id, EducationalInstitutionDTO u)
        {
            return _EducationalInstitutionDL.UpdateEducationalInstitution(id, mapper.Map<EducationalInstitutionDTO, EducationalInstitution>(u));
        }

    }
}

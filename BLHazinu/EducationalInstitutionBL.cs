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
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGender(string gender, int age)
        {
            List<EducationalInstitution> AllEducationalInstitution = _EducationalInstitutionDL.GetAllInstitutionsCategoriesByGender(gender, age);
            return mapper.Map<List<EducationalInstitution>, List<EducationalInstitutionDTO>>(AllEducationalInstitution);
        }
        //בשביל המילוי מוסד לימודים חדש
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGenderCity(string gender, int age, string city)
        {
            List<EducationalInstitution> AllEducationalInstitution = _EducationalInstitutionDL.GetAllInstitutionsCategoriesByGenderCity(gender, age,city);
            return mapper.Map<List<EducationalInstitution>, List<EducationalInstitutionDTO>>(AllEducationalInstitution);
    }
        public bool DeleteEducationalInstitution(string nameI)
        {
            return _EducationalInstitutionDL.DeleteEducationalInstitution(nameI);
        }
        public bool AddEducationalInstitution(EducationalInstitutionDTO u)
        {
            return _EducationalInstitutionDL.AddEducationalInstitution(mapper.Map<EducationalInstitutionDTO, EducationalInstitution>(u));
        }
        public bool UpdateEducationalInstitution(string nameI, EducationalInstitutionDTO u)
        {
            return _EducationalInstitutionDL.UpdateEducationalInstitution(nameI, mapper.Map<EducationalInstitutionDTO, EducationalInstitution>(u));
        }

    }
}

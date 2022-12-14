using DalHazinu.Models;
using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEducationalInstitutionBL
    {
        bool AddEducationalInstitution(EducationalInstitutionDTO u);
        bool DeleteEducationalInstitution(string nameI);
        List<EducationalInstitutionDTO> GetAllEducationalInstitution();
        List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGender(string gender, int age);
        bool UpdateEducationalInstitution(string nameI, EducationalInstitutionDTO u);
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGenderCity(string gender, int age, string city);

    }
}
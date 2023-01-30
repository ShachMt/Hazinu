using DalHazinu.Models;
using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEducationalInstitutionBL
    {
        int AddEducationalInstitution(EducationalInstitutionDTO u);
        bool DeleteEducationalInstitution(int id);
        List<EducationalInstitutionDTO> GetAllEducationalInstitution();
        List<EducationalInstitutionDTO> GetAllInstitutionsCategories(int idCategory);
        bool UpdateEducationalInstitution(int id, EducationalInstitutionDTO u);
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGenderCity(int idCategory, string city);

    }
}
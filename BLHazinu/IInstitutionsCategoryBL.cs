using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IInstitutionsCategoryBL
    {
        bool AddInstitutionsCategory(InstitutionsCategoryDTO u);
        bool DeleteInstitutionsCategory(int id);
        List<InstitutionsCategoryDTO> GetAllInstitutionsCategories();
        List<InstitutionsCategoryDTO> GetAllInstitutionsCategoriesByGender(string gender,int age);
        bool UpdateInstitutionsCategory(int id, InstitutionsCategoryDTO u);
    }
}
using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IStylesInstitutionBL
    {
        int AddStylesInstitution(StylesInstitutionDTO a);
        bool DeleteStylesInstitution(int id);
        List<StylesInstitutionDTO> GetAllStylesInstitution();
        bool UpdateStylesInstitution(int id, StylesInstitutionDTO a);
    }
}
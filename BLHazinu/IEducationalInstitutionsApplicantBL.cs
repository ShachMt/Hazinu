using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEducationalInstitutionsApplicantBL
    {
        bool AddEducational(EducationalInstitutionsApplicantDTO u);
        bool DeletEducational(int idEdu);
        List<EducationalInstitutionsApplicantDTO> GetAllEducationalInstitution(int id);
        List<EducationalInstitutionDTO> GetAllNameEducationalInstitution(int id, string status);
        bool UpdateEducational(int id, EducationalInstitutionsApplicantDTO u);
    }
}
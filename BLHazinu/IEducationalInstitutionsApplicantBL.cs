using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEducationalInstitutionsApplicantBL
    {
        int AddEducational(EducationalInstitutionsApplicantDTO u);
        bool DeletEducational(int idEdu);
        List<EducationalInstitutionsApplicantDTO> GetAllEducationalInstitution(int id);
        List<EducationalInstitutionsApplicantDTO> GetAllNameEducationalInstitution(int id, string status);
        bool UpdateEducational(int id, EducationalInstitutionsApplicantDTO u);
    }
}
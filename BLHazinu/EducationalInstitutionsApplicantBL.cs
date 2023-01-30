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
    public class EducationalInstitutionsApplicantBL : IEducationalInstitutionsApplicantBL
    {

        IMapper mapper;
        public EducationalInstitutionsApplicantBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        EducationalInstitutionsApplicantDL _EducationalInstitutionsApplicantDL = new EducationalInstitutionsApplicantDL();

        //החזרת רשימת מוסדות לפי היוזר
        public List<EducationalInstitutionsApplicantDTO> GetAllEducationalInstitution(int id)
        {
            List<EducationalInstitutionsApplicant> listEducationalInstitutionsApplicant = _EducationalInstitutionsApplicantDL.GetAllEducationalInstitution(id);
            return mapper.Map<List<EducationalInstitutionsApplicant>, List<EducationalInstitutionsApplicantDTO>>(listEducationalInstitutionsApplicant);
        }
        //החזרת שמות לימודים לפי סטטוס- עבר או הווה
        public List<EducationalInstitutionsApplicantDTO> GetAllNameEducationalInstitution(int id, string status)
        {
            List<EducationalInstitutionsApplicant> listEducationalInstitutionsApplicant = _EducationalInstitutionsApplicantDL.GetAllNameEducationalInstitution(id, status);
            return mapper.Map<List<EducationalInstitutionsApplicant>, List<EducationalInstitutionsApplicantDTO>>(listEducationalInstitutionsApplicant);
        }


        //מחיקת מוסד לימוד 
        public bool DeletEducational(int idEdu)
        {
            return _EducationalInstitutionsApplicantDL.DeletEducational(idEdu);
        }
        // הוספת מוסד לימוד לפונה
        public int AddEducational(EducationalInstitutionsApplicantDTO u)
        {
            return _EducationalInstitutionsApplicantDL.AddEducational(mapper.Map<EducationalInstitutionsApplicantDTO, EducationalInstitutionsApplicant>(u));

        }
        //עדכון מוסד לימוד

        public bool UpdateEducational(int id, EducationalInstitutionsApplicantDTO u)
        {
            return _EducationalInstitutionsApplicantDL.UpdateEducational(id, mapper.Map<EducationalInstitutionsApplicantDTO, EducationalInstitutionsApplicant>(u));
        }
    }
}

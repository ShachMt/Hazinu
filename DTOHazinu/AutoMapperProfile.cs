using DalHazinu.Models;
using DTOHazinu.Models;
using System;

namespace DTOHazinu
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<EmployeesDTO, Employees>();
            CreateMap<Employees, EmployeesDTO>();

            CreateMap<ApplyDTO, Apply>();
            CreateMap<Apply, ApplyDTO>();
            
            CreateMap<JobsDTO, Jobs>();
            CreateMap<Jobs, JobsDTO>();

            CreateMap<AddressDTO, Address>();
            CreateMap<Address, AddressDTO>();
            
            CreateMap<TheCauseReferralDTO, TheCauseReferral>();
            CreateMap<TheCauseReferral, TheCauseReferralDTO>();

            CreateMap<TaskDTO, Task>();
            CreateMap<Task, TaskDTO>();

            CreateMap<StylesInstitutionDTO, StylesInstitution>();
            CreateMap<StylesInstitution, StylesInstitutionDTO>();

            CreateMap<InstitutionsCategoryDTO, InstitutionsCategory>();
            CreateMap<InstitutionsCategory, InstitutionsCategoryDTO>();

            CreateMap<StatusDTO, Status>();
            CreateMap<Status, StatusDTO>();

            CreateMap<SectorDTO, Sector>();
            CreateMap<Sector, SectorDTO>();

            CreateMap<FilesDTO, Files>();
            CreateMap<Files, FilesDTO>();

            CreateMap<DetailsAskerDTO, DetailsAsker>();
            CreateMap<DetailsAsker, DetailsAskerDTO>();

            CreateMap<EducationalInstitutionDTO, EducationalInstitution>();
            CreateMap<EducationalInstitution, EducationalInstitutionDTO>();

            CreateMap<AgeRangeDTO, AgeRange>();
            CreateMap<AgeRange, AgeRangeDTO>();

            CreateMap<EducationalInstitutionsApplicantDTO, EducationalInstitutionsApplicant>();
            CreateMap<EducationalInstitutionsApplicant, EducationalInstitutionsApplicantDTO>();

            CreateMap<MatureCharacterDTO, MatureCharacter>();
            CreateMap<MatureCharacter, MatureCharacterDTO>();

            CreateMap<PatientDetailsDTO, PatientDetails>();
            CreateMap<PatientDetails, PatientDetailsDTO>();

            CreateMap<TreatmentDetailsDTO, TreatmentDetails>();
            CreateMap<TreatmentDetails, TreatmentDetailsDTO>();

            CreateMap<FamilyDTO, Family>();
            CreateMap<Family, FamilyDTO>();

            CreateMap<EducationalInstitutionsApplicantDTO, EducationalInstitutionsApplicant>();
            CreateMap<EducationalInstitutionsApplicant, EducationalInstitutionsApplicantDTO>();

             CreateMap<TerapistDTO, Terapist>();
            CreateMap<Terapist, TerapistDTO>();
        }
    }
}

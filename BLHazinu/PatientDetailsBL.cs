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
    public class PatientDetailsBL : IPatientDetailsBL
    {
        IMapper mapper;
        public PatientDetailsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        PatientDetailsDL _PatientDetailsDL = new PatientDetailsDL();

        public List<PatientDetailsDTO> GetAllPatientDetails()
        {
            List<PatientDetails> AllPatientDetails = _PatientDetailsDL.GetAllPatientDetails();
            return mapper.Map<List<PatientDetails>, List<PatientDetailsDTO>>(AllPatientDetails);
        }

        public int AddPatientDetails(PatientDetailsDTO u)
        {

            return _PatientDetailsDL.AddPatientDetails(mapper.Map<PatientDetailsDTO, PatientDetails>(u));

        }
        public bool DeleatPatientDetails(int id)
        {
            return _PatientDetailsDL.DeletePatientDetails(id);

        }
        public bool UpdatePatientDetails(int id, PatientDetailsDTO u)
        {
            return _PatientDetailsDL.UpdatePatientDetails(id, mapper.Map<PatientDetailsDTO, PatientDetails>(u));
        }
    }
}

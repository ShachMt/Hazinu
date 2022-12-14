using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IPatientDetailsBL
    {
        bool AddPatientDetails(PatientDetailsDTO u);
        bool DeleatPatientDetails(int id);
        List<PatientDetailsDTO> GetAllPatientDetails();
        bool UpdatePatientDetails(int id, PatientDetailsDTO u);
    }
}
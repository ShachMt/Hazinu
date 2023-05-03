using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ITreatmentDetailsBL
    {
        bool AddTreatmentDetails(TreatmentDetailsDTO u);
        bool DeleatTreatmentDetails(int id, int applyId);
        List<TreatmentDetailsDTO> GetAllTreatmentDetails(int applyId);
        TreatmentDetailsDTO GetTreatmentDetailsByApplyState(int applyId);

        bool UpdateTreatmentDetails(int id, TreatmentDetailsDTO u);
        int EmployeesApply(int apply);

    }
}
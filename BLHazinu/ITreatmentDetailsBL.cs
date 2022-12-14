using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ITreatmentDetailsBL
    {
        bool AddTreatmentDetails(TreatmentDetailsDTO u);
        bool DeleatTreatmentDetails(int id);
        List<TreatmentDetailsDTO> GetAllTreatmentDetails(int applyId);
        bool UpdateTreatmentDetails(int id, TreatmentDetailsDTO u);
    }
}
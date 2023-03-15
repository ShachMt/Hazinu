using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IApplyBL
    {
        int AddApply(ApplyDTO u);
        bool DeleatApply(int id);
        List<ApplyDTO> GetAllApplies();
        List<ApplyDTO> GetAllAppliesByPhone(string phon);
        List<ApplyDTO> GetAllAppliesUserEmployee(int idEmployees);
        List<ApplyDTO> GetAllApplyByStatusEmailTerapist(int status, int idEmployees);
        List<ApplyDTO> GetAllApplyByStatus(int status);
        ApplyDTO GetApplyById(int applyId);
        List<ApplyDTO> GetAllAppliesByEmployee(int id);

        bool UpdateApply(int id, ApplyDTO u);
    }
}
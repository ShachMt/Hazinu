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
        List<ApplyDTO> GetAllAppliesUserEmployee(string email);
        List<ApplyDTO> GetAllApplyByStatusEmailTerapist(int status, string email);
        List<ApplyDTO> GetAllApplyByStatus(int status);

        bool UpdateApply(int id, ApplyDTO u);
    }
}
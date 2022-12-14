using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IApplyBL
    {
        bool AddApply(ApplyDTO u);
        bool DeleatApply(int id);
        List<ApplyDTO> GetAllApplies();
        List<ApplyDTO> GetAllAppliesByPhone(string phon);
        List<ApplyDTO> GetAllAppliesUserEmployee(string email);
        bool UpdateApply(int id, ApplyDTO u);
    }
}
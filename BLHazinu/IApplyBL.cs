using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IApplyBL
    {
        List<ApplyDTO> GetAllAppliesByStatus(int status);
        List<ApplyDTO> GetAllApplies();
    }
}
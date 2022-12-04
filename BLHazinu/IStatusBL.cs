using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IStatusBL
    {
        bool AddStatus(StatusDTO status);
        bool DeleteStatus(int id);
        List<StatusDTO> GetAllStatus();
        bool UpdateStatus(int id, StatusDTO status);
    }
}
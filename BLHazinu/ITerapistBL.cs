using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ITerapistBL
    {
        int AddTerapist(TerapistDTO u);
        bool DeleatTerapist(int id);
        List<TerapistDTO> GetAllTerapist();
        bool UpdateTerapist(int id, TerapistDTO u);
    }
}
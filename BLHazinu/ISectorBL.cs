using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ISectorBL
    {
        int AddSector(SectorDTO a);
        bool DeleteSector(int id);
        List<SectorDTO> GetAllSector();
        bool UpdateSector(int id, SectorDTO a);
    }
}
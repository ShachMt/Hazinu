using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ISectorBL
    {
        bool AddSector(SectorDTO a);
        bool DeleteSector(int id);
        List<SectorDTO> GetAllSector();
        bool UpdateSector(int id, SectorDTO a);
    }
}
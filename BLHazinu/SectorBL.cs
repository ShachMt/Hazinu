using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
    public class SectorBL : ISectorBL
    {
        IMapper mapper;
        public SectorBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        SectorDL _SectorDL = new SectorDL();

        public List<SectorDTO> GetAllSector()
        {
            List<Sector> AllSector = _SectorDL.GetAllSector();
            return mapper.Map<List<Sector>, List<SectorDTO>>(AllSector);
        }
        public bool DeleteSector(int id)
        {
            return _SectorDL.DeleteSector(id);
        }
        public int AddSector(SectorDTO a)
        {
            return _SectorDL.AddSector(mapper.Map<SectorDTO, Sector>(a));

        }
        public bool UpdateSector(int id, SectorDTO a)
        {
            return _SectorDL.UpdateSector(id, mapper.Map<SectorDTO, Sector>(a));

        }

    }
}

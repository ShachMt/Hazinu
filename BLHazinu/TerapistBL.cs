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
    public class TerapistBL : ITerapistBL
    {
        IMapper mapper;
        public TerapistBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        TerapistDL _TerapistDL = new TerapistDL();

        public List<TerapistDTO> GetAllTerapist()
        {
            List<Terapist> terapists = _TerapistDL.GetAllTerapist();
            return mapper.Map<List<Terapist>, List<TerapistDTO>>(terapists);

        }
        public int AddTerapist(TerapistDTO u)
        {

            return _TerapistDL.AddTerapist(mapper.Map<TerapistDTO, Terapist>(u));

        }
        public bool DeleatTerapist(int id)
        {
            return _TerapistDL.DeleteTerapist(id);

        }
        public bool UpdateTerapist(int id, TerapistDTO u)
        {
            return _TerapistDL.UpdateTerapist(id, mapper.Map<TerapistDTO, Terapist>(u));
        }
    }
}

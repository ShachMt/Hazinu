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
    public class DetailsAskerBL : IDetailsAskerBL
    {
        IMapper mapper;
        public DetailsAskerBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        DetailsAskerDL _DetailsAskerDL = new DetailsAskerDL();
        public int GetIdDetailsAsker(int idUserAsker)
        {
            return _DetailsAskerDL.GetIdDetailsAsker(idUserAsker);
        }
        public List<DetailsAskerDTO> GetAllDetailsAsker()
        {
            List<DetailsAsker> listDetailsAsker = _DetailsAskerDL.GetAllDetailsAsker();
            return mapper.Map<List<DetailsAsker>, List<DetailsAskerDTO>>(listDetailsAsker);
        }
        public DetailsAskerDTO GetDetailsAskerByApplyId(int applyId)
        {
            DetailsAsker detailsAsker = _DetailsAskerDL.GetDetailsAskerByApplyId(applyId);
            return mapper.Map<DetailsAsker, DetailsAskerDTO>(detailsAsker);

        }
        public DetailsAskerDTO GetDetailsAskerByUserAskerId(int userId)
        {
            DetailsAsker detailsAsker = _DetailsAskerDL.GetDetailsAskerByUserAskerId(userId);
            return mapper.Map<DetailsAsker, DetailsAskerDTO>(detailsAsker);
        }
        public List<DetailsAskerDTO> GetAllDetailsAskerByResone(int resone)
        {

            List<DetailsAsker> listDetailsAsker = _DetailsAskerDL.GetAllDetailsAskerByResone(resone);
            return mapper.Map<List<DetailsAsker>, List<DetailsAskerDTO>>(listDetailsAsker);
        }
        public int AddDetailsAsker(DetailsAskerDTO u)
        {

            return _DetailsAskerDL.AddDetailsAsker(mapper.Map<DetailsAskerDTO, DetailsAsker>(u));

        }
        public bool DeleatDetailsAsker(int id)
        {
            return _DetailsAskerDL.DeleteDetailsAsker(id);

        }
        public bool UpdateDetailsAsker(int id, DetailsAskerDTO u)
        {
            return _DetailsAskerDL.UpdateDetailsAsker(id, mapper.Map<DetailsAskerDTO, DetailsAsker>(u));
        }



    }
}

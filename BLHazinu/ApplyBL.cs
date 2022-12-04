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
    public class ApplyBL : IApplyBL
    {


        IMapper mapper;
        public ApplyBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        ApplyDL _ApplyDL = new ApplyDL();

        public List<ApplyDTO> GetAllApplies()
        {
            List<Apply> allApplies = _ApplyDL.GetAllApplies();
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);
        }

        public List<ApplyDTO> GetAllAppliesByStatus(int status)
        {
            List<Apply> allApplies = _ApplyDL.GetAllAppliesByStatus(status);
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);

        }
    }
}

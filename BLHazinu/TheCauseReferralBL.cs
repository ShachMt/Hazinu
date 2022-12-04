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
    public class TheCauseReferralBL : ITheCauseReferralBL
    {
        IMapper mapper;
        public TheCauseReferralBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        TheCauseReferralDL _TheCauseReferralDL = new TheCauseReferralDL();

        public List<TheCauseReferralDTO> GetTheCauseReferral()
        {
            List<TheCauseReferral> listTheCauseReferral = _TheCauseReferralDL.GetTheCauseReferral();
            return mapper.Map<List<TheCauseReferral>, List<TheCauseReferralDTO>>(listTheCauseReferral);

        }

        public bool DeleteTheCauseReferral(int id)
        {
            return _TheCauseReferralDL.DeleteTheCauseReferral(id);
        }
        public bool AddTheCauseReferral(TheCauseReferralDTO c)
        {
            return _TheCauseReferralDL.AddTheCauseReferral(mapper.Map<TheCauseReferralDTO, TheCauseReferral>(c));
        }

        public bool UpdateTheCauseReferral(int id, TheCauseReferralDTO c)
        {
            return _TheCauseReferralDL.UpdateTheCauseReferral(id, mapper.Map<TheCauseReferralDTO, TheCauseReferral>(c));
        }
    }
}

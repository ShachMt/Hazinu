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
        public List<ApplyDTO> GetAllAppliesByPhone(string phon)
        {
            List<Apply> allApplies = _ApplyDL.GetAllAppliesByPhone(phon);
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);
        }
        public List<ApplyDTO> GetAllAppliesUserEmployee(string email)
        {
            List<Apply> allApplies = _ApplyDL.GetAllAppliesUserEmployee(email);
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);
        }

        public int AddApply(ApplyDTO u)
        {

            return _ApplyDL.AddApply(mapper.Map<ApplyDTO, Apply>(u));

        }
        public bool DeleatApply(int id)
        {
            return _ApplyDL.DeleteApply(id);

        }
        public bool UpdateApply(int id, ApplyDTO u)
        {
            return _ApplyDL.UpdateApply(id, mapper.Map<ApplyDTO, Apply>(u));
        }

        public List<ApplyDTO> GetAllApplyByStatusEmailTerapist(int status, string email)
        {
            List<Apply> allApplies = _ApplyDL.GetAllApplyByStatusEmailTerapist(status, email);
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);
        }
        //החזרת פניות לפי ססטוס- בשביל מנהל הפניות לסיווג ובשביל האינטייק 
        public List<ApplyDTO> GetAllApplyByStatus(int status)
        {
            List<Apply> allApplies = _ApplyDL.GetAllApplyByStatus(status);
            return mapper.Map<List<Apply>, List<ApplyDTO>>(allApplies);
        }
    }
}

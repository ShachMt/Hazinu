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
    public class FamilyBL : IFamilyBL
    {
        IMapper mapper;
        public FamilyBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        FamilyDL _FamilyDL = new FamilyDL();

        public List<FamilyDTO> GetAllFamily()
        {
            List<Family> AllFamily = _FamilyDL.GetAllFamilies();
            return mapper.Map<List<Family>, List<FamilyDTO>>(AllFamily);
        }

        public int AddFamily(FamilyDTO u)
        {

            return _FamilyDL.AddAFamily(mapper.Map<FamilyDTO, Family>(u));

        }
        public bool DeleatFamily(int id)
        {
            return _FamilyDL.DeleteFamily(id);

        }
        public bool UpdateFamily(int id, FamilyDTO u)
        {
            return _FamilyDL.UpdateFamily(id, mapper.Map<FamilyDTO, Family>(u));
        }
    }
}

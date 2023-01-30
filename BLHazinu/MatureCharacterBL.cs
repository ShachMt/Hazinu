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
    public class MatureCharacterBL : IMatureCharacterBL
    {
        IMapper mapper;
        public MatureCharacterBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        MatureCharacterDL _MatureCharacterDL = new MatureCharacterDL();

        public List<MatureCharacterDTO> GetAllMatureCharacter()
        {
            List<MatureCharacter> AllMatureCharacter = _MatureCharacterDL.GetAllMatureCharacter();
            return mapper.Map<List<MatureCharacter>, List<MatureCharacterDTO>>(AllMatureCharacter);
        }

        public int AddMatureCharacter(MatureCharacterDTO u)
        {

            return _MatureCharacterDL.AddMatureCharacter(mapper.Map<MatureCharacterDTO, MatureCharacter>(u));

        }
        public bool DeleatMatureCharacter(int id)
        {
            return _MatureCharacterDL.DeleteMatureCharacter(id);

        }
        public bool UpdateMatureCharacter(int id, MatureCharacterDTO u)
        {
            return _MatureCharacterDL.UpdateMatureCharacter(id, mapper.Map<MatureCharacterDTO, MatureCharacter>(u));
        }
    }
}

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
    public class AgeRangeBL : IAgeRangeBL
    {
        IMapper mapper;
        public AgeRangeBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        AgeRangeDL _AgeRangeDL = new AgeRangeDL();

        public List<AgeRangeDTO> GetAllAgeRange()
        {
            List<AgeRange> AllAgeRange = _AgeRangeDL.GetAllAgeRange();
            return mapper.Map<List<AgeRange>, List<AgeRangeDTO>>(AllAgeRange);
        }
        public int GetIdAgeRangeByAge(int age)
        {
          return  _AgeRangeDL.GetIdAgeRangeByAge(age);
        }
        public bool AddJobsAgeRange(AgeRangeDTO u)
        {

            return _AgeRangeDL.AddAgeRange(mapper.Map<AgeRangeDTO, AgeRange>(u));

        }
        public bool DeleatAgeRange(int id)
        {
            return _AgeRangeDL.DeleteAgeRange(id);

        }
        public bool UpdateAgeRange(int id, AgeRangeDTO u)
        {
            return _AgeRangeDL.UpdateAgeRange(id, mapper.Map<AgeRangeDTO, AgeRange>(u));
        }

    }
}

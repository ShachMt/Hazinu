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
    public class JobsBL : IJobsBL
    {
        IMapper mapper;
        public JobsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        JobsDL _JobsDL = new JobsDL();

        public List<JobsDTO> GetAllJobs()
        {
            List<Jobs> AllJobs = _JobsDL.GetAllJobs();
            return mapper.Map<List<Jobs>, List<JobsDTO>>(AllJobs);
        }

        public bool AddJobs(JobsDTO u)
        {

            return _JobsDL.AddJobs(mapper.Map<JobsDTO, Jobs>(u));

        }
        public bool DeleatJobs(int id)
        {
            return _JobsDL.DeleteJobs(id);

        }
        public bool UpdateJobs(int id, JobsDTO u)
        {
            return _JobsDL.UpdateJobs(id, mapper.Map<JobsDTO, Jobs>(u));
        }

    }
}

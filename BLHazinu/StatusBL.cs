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
    public class StatusBL : IStatusBL
    {
        IMapper mapper;
        public StatusBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        StatusDL _StatusDL = new StatusDL();

        public List<StatusDTO> GetAllStatus()
        {
            List<Status> AllStatus = _StatusDL.GetAllStatus();
            return mapper.Map<List<Status>, List<StatusDTO>>(AllStatus);
        }
        public bool DeleteStatus(int id)
        {
            return _StatusDL.DeleteStatus(id);
        }
        public bool AddStatus(StatusDTO status)
        {
            return _StatusDL.AddStatus(mapper.Map<StatusDTO, Status>(status));

        }
        public bool UpdateStatus(int id, StatusDTO status)
        {
            return _StatusDL.UpdateStatus(id, mapper.Map<StatusDTO, Status>(status));

        }
    }
}

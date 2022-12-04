using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLHazinu
{
    public class TaskBL : ITaskBL
    {
        IMapper mapper;
        public TaskBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        TaskDL _TaskDL = new TaskDL();

        public List<TaskDTO> GetAllTask()
        {
            List<Task> AllTasks = _TaskDL.GetAllTask();
            return mapper.Map<List<Task>, List<TaskDTO>>(AllTasks);
        }
        public bool DeleteTask(int id)
        {
            return _TaskDL.DeleteTask(id);
        }
        public bool AddTask(TaskDTO a)
        {
            return _TaskDL.AddTask(mapper.Map<TaskDTO, Task>(a));

        }
        public bool UpdateTask(int id, TaskDTO a)
        {
            return _TaskDL.UpdateTask(id, mapper.Map<TaskDTO, Task>(a));

        }


    }
}

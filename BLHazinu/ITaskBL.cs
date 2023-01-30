using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ITaskBL
    {
        int AddTask(TaskDTO a);
        bool DeleteTask(int id);
        List<TaskDTO> GetAllTask();
        bool UpdateTask(int id, TaskDTO a);
    }
}
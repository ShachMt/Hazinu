using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IJobsBL
    {
        List<JobsDTO> GetAllJobs();
        bool AddJobs(JobsDTO u);
        bool DeleatJobs(int id);
        bool UpdateJobs(int id, JobsDTO u);
    }
}
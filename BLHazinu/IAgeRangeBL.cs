using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IAgeRangeBL
    {
        int GetIdAgeRangeByAge(int age);
        bool AddJobsAgeRange(AgeRangeDTO u);
        bool DeleatAgeRange(int id);
        List<AgeRangeDTO> GetAllAgeRange();
        bool UpdateAgeRange(int id, AgeRangeDTO u);
    }
}
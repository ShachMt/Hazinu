using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IDetailsAskerBL
    {
        bool AddDetailsAsker(DetailsAskerDTO u);
        bool DeleatDetailsAsker(int id);
        List<DetailsAskerDTO> GetAllDetailsAsker();
        List<DetailsAskerDTO> GetAllDetailsAskerByResone(int resone);
        bool UpdateDetailsAsker(int id, DetailsAskerDTO u);
    }
}
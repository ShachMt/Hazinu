using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IDetailsAskerBL
    {
        int AddDetailsAsker(DetailsAskerDTO u);
        bool DeleatDetailsAsker(int id);
        List<DetailsAskerDTO> GetAllDetailsAsker();
        List<DetailsAskerDTO> GetAllDetailsAskerByResone(int resone);
        DetailsAskerDTO GetDetailsAskerByApplyId(int applyId);
        bool UpdateDetailsAsker(int id, DetailsAskerDTO u);
        DetailsAskerDTO GetDetailsAskerByUserAskerId(int userId);
        int GetIdDetailsAsker(int idUserAsker);


    }
}
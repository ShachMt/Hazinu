using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface ITheCauseReferralBL
    {
        bool AddTheCauseReferral(TheCauseReferralDTO c);
        bool DeleteTheCauseReferral(int id);
        List<TheCauseReferralDTO> GetTheCauseReferral();
        bool UpdateTheCauseReferral(int id, TheCauseReferralDTO c);
    }
}
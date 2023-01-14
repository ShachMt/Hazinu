using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IFamilyBL
    {
        int AddFamily(FamilyDTO u);
        bool DeleatFamily(int id);
        List<FamilyDTO> GetAllFamily();
        bool UpdateFamily(int id, FamilyDTO u);
    }
}
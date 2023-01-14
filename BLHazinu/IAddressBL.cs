using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IAddressBL
    {
        int AddAddress(AddressDTO a);
        bool DeleatAddress(int id);
        List<AddressDTO> GetAllAddress();
        List<AddressDTO> GetAllAddressByCityId(string city);
        bool UpdateAddress(int id, AddressDTO a);
    }
}
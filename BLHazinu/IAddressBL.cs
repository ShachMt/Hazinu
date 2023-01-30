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
        List<string> GetAllCities();

        bool UpdateAddress(int id, AddressDTO a);
        int GetIdAddressByCity(string nameCity);

    }
}
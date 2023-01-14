using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
    public class AddressBL : IAddressBL
    {
        IMapper mapper;
        public AddressBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        AddressDL _AddressDL = new AddressDL();
        public List<AddressDTO> GetAllAddress()
        {
            List<Address> listAddress = _AddressDL.GetAllAddress();
            return mapper.Map<List<Address>, List<AddressDTO>>(listAddress);
        }
        public List<AddressDTO> GetAllAddressByCityId(string city)

        {
            List<Address> listAddress = _AddressDL.GetAllAddressByNameCity(city);
            return mapper.Map<List<Address>, List<AddressDTO>>(listAddress);
        }
        public int AddAddress(AddressDTO a)
        {

            return _AddressDL.AddAddress(mapper.Map<AddressDTO, Address>(a));

        }
        public bool DeleatAddress(int id)
        {
            return _AddressDL.DeleteAddress(id);

        }
        public bool UpdateAddress(int id, AddressDTO a)
        {
            return _AddressDL.UpdateAddress(id, mapper.Map<AddressDTO, Address>(a));
        }


    }
}

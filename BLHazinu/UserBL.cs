using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;

namespace BLHazinu
{
    public class UserBL : IUserBL
    {
        IMapper mapper;
        public UserBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        UserDL _UserDL = new UserDL();

        public bool AddUser(UserDTO u)
        {

            return _UserDL.AddUsers(mapper.Map<UserDTO, User>(u));

        }
        public bool DeleatUser(string phone)
        {
            return _UserDL.DeleteUser(phone);

        }
        public bool UpdateUser(string phon, UserDTO u)
        {
            return _UserDL.UpdateUser(phon, mapper.Map<UserDTO, User>(u));
        }

    }
}

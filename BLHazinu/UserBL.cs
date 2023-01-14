using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;

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

        public List<UserDTO> GetUsers()
        {
            List<User> users = _UserDL.GetUsers();
            return mapper.Map<List<User>, List<UserDTO>>(users);

        }
        public UserDTO GetUserByPhone(string phone)
        {
            User user = _UserDL.GetUserByPhone(phone);
            return mapper.Map<User, UserDTO>(user);

        }

        public int AddUser(UserDTO u)
        {

            return _UserDL.AddUsers(mapper.Map<UserDTO, User>(u));

        }
        public bool DeleatUser(string phone)
        {
            return _UserDL.DeleteUser(phone);

        }
        public bool UpdateUser(int id, UserDTO u)
        {
            return _UserDL.UpdateUser(id, mapper.Map<UserDTO, User>(u));
        }
        

    }
}

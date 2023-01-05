using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IUserBL
    {
        int AddUser(UserDTO u);
        bool DeleatUser(string phone);
        bool UpdateUser(string phon, UserDTO u);
        List<UserDTO> GetUsers();
        UserDTO GetUserByPhone(string phone);

    }
}
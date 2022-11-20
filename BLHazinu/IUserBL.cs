using DTOHazinu.Models;

namespace BLHazinu
{
    public interface IUserBL
    {
        bool AddUser(UserDTO u);
        bool DeleatUser(string phone);
        bool UpdateUser(string phon, UserDTO u);
    }
}
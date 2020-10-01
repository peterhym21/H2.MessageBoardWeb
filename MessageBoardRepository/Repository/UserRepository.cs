using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardRepository.Repository
{
    public class UserRepository : IUsersRepository
    {
        private readonly string _conString;
        private List<Users> UserList;

        public UserRepository(string conString)
        {
            _conString = conString;
        }

    }
}

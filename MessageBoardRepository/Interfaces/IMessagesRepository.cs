using MessageBoardRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardRepository.Interfaces
{
    public interface IMessagesRepository
    {
        List<Messages> ReadMessages();
        List<Messages> ReadMessagesByCategory(int CategoryId);
        int CreateMessages();
        int UpdateMessage();
        int DeleteMessage();
    }
}

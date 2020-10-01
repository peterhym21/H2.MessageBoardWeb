using MessageBoardRepository.Entities;
using MessageBoardRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardRepository.Repository
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly string _conString;
        private List<Messages> messagesList;

        public MessagesRepository(string conString)
        {
            _conString = conString;
        }


        public List<Messages> ReadMessages()
        {
            messagesList = new List<Messages>();
            SqlConnection con = new SqlConnection(_conString);
            SqlCommand cmd = new SqlCommand("ReadMessages", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                messagesList.Add(new Messages { MessageId = (int)myReader["MessageId"], Title = (string)myReader["Title"] });
            }

            con.Close();
            return messagesList;
        }


        public List<Messages> ReadMessagesByCategory(int CategoryId)
        {
            messagesList = new List<Messages>();
            SqlConnection con = new SqlConnection(_conString);
            SqlCommand cmd = new SqlCommand("GetCategoryMessage", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CategoryId", CategoryId);

            con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                messagesList.Add(new Messages { MessageId = (int)myReader["MessageId"], Title = (string)myReader["Title"], Content = (string)myReader["Content"] });
            }

            con.Close();
            return messagesList;
        }


        public int CreateMessages()
        {
            throw new NotImplementedException();
        }


        public int UpdateMessage()
        {
            throw new NotImplementedException();
        }

        public int DeleteMessage()
        {
            throw new NotImplementedException();
        }

        
    }
}

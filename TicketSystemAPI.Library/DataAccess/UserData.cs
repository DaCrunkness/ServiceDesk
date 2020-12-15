using System.Collections.Generic;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class UserData
    {
        public static int CreateUser(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            UserModel data = new UserModel
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Users (FirstName, LastName, PhoneNumber, EmailAddress)
                                         values (@FirstName, @LastName, @PhoneNumber, @EmailAddress);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public List<UserModel> GetUserById(string Id)
        {
            string sql = $"select * from dbo.Users where Id = { Id };";
            return SqlDataAccess.LoadData<UserModel>(sql);

        }
        public static List<UserModel> LoadData()
        {
            string sql = @"select FirstName, LastName, PhoneNumber, EmailAddress from dbo.Users;";

            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}

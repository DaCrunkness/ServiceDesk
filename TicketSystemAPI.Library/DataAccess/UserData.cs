using System.Collections.Generic;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class UserData
    {
        public static int CreateUser(string firstName, string lastName, string phoneNumber, string emailAddress, string group)
        {
            UserModel data = new UserModel
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress,
                UsersGroup = group
            };

            string sql = @"insert into dbo.Users (FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup)
                                         values (@FirstName, @LastName, @PhoneNumber, @EmailAddress, @UsersGroup);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> GetUserById(string email)
        {
            string sql = $"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users where EmailAddress = '{ email }';";
            return SqlDataAccess.LoadData<UserModel>(sql);

        }
        public static List<UserModel> GetUserGroup(string group)
        {
            string sql = $"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users where UsersGroup = '{ group }';";
            return SqlDataAccess.LoadData<UserModel>(sql);

        }
        public static List<UserModel> LoadData()
        {
            string sql = @"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users;";

            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}

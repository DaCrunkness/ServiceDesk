using System.Collections.Generic;
using System.Linq;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class UserData
    {
        public static void CreateUser(string firstName, string lastName, string phoneNumber, string emailAddress, string usersGroup)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber, EmailAddress = emailAddress, UsersGroup = usersGroup };
            sql.SaveData(DBStructure.USER_CREATION, p, DBStructure.DBNAME);
        }

        public static UserModel GetUserById(string emailAddress)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { EmailAddress = emailAddress };
            var output = sql.LoadData<UserModel, dynamic>(DBStructure.USER_LOOKUP, p, DBStructure.DBNAME);
            return output.First();
        }

        public static List<UserModel> LoadData()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { };
            return sql.LoadData<UserModel, dynamic>(DBStructure.USER_LOADUSERS, p, DBStructure.DBNAME);
        }

        //public static int CreateUser(string firstName, string lastName, string phoneNumber, string emailAddress, string group)
        //{
        //    UserModel data = new UserModel
        //    {
        //        FirstName = firstName,
        //        LastName = lastName,
        //        PhoneNumber = phoneNumber,
        //        EmailAddress = emailAddress,
        //        UsersGroup = group
        //    };

        //    string sql = @"insert into dbo.Users (FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup)
        //                                 values (@FirstName, @LastName, @PhoneNumber, @EmailAddress, @UsersGroup);";
        //    return SqlDataAccess.SaveData(sql, data);
        //}

        //public static List<UserModel> GetUserById(string email)
        //{
        //    string sql = $"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users where EmailAddress = '{ email }';";
        //    return SqlDataAccess.LoadData<UserModel>(sql);

        //}
        //public static List<UserModel> GetUserGroup(string group)
        //{
        //    string sql = $"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users where UsersGroup = '{ group }';";
        //    return SqlDataAccess.LoadData<UserModel>(sql);

        //}
        //public static List<UserModel> LoadData()
        //{
        //    string sql = @"select FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup from dbo.Users;";

        //    return SqlDataAccess.LoadData<UserModel>(sql);
        //}
    }
}

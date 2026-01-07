using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL
    {
        public bool InsertUserDAL(User U)
        {
            return new DbCon().UDI("INSERT INTO Alexx (FirstName,LastName,Email,Address,Age, Gender, Country) VALUES ('" + U.FirstName + "','" + U.LastName + "','" + U.Email + "','"+U.Address+"','"+U.Age+"','"+U.Gender+"','"+U.Country+"')");
        }
        public bool UpdateUserDAL(User U)
        {
            return new DbCon().UDI(
                "UPDATE [Alexx] SET " +
                "FirstName='" + U.FirstName +
                "', LastName='" + U.LastName +
                "', Email='" + U.Email +
                "', Address='" + U.Address +
                "', Age='" + U.Age +
                "', Gender='" + U.Gender +
                "', Country='" + U.Country +
                "' WHERE ID=" + U.ID
            );
        }

        public bool DeleteUserDAL(User U)
        {
            return new DbCon().UDI("DELETE FROM Alexx WHERE ID='" + U.ID + "'");
        }

        public DataTable GetUsersDAL()
        {
            return new DbCon().Search("SELECT * FROM Alexx");
        }
        public DataTable GetUserDAL(User U)
        {
            return new DbCon().Search("SELECT * FROM Alexx WHERE ID = '" + U.ID + "'");
        }
    }
}

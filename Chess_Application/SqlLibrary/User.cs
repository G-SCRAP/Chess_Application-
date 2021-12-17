using System;
using ChessBoardModel3;
using System.Collections.Generic;
using System.Text;

namespace SqlLibrary
{
    public class User
    {
        public static void SavePerson(Person person)
        //Saves a user
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (ID, Password, Buisness, First, Last, Email) values (@ID, @Password, @Buisness, @First, @Last, @Email)", person);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        //Gets connection string
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

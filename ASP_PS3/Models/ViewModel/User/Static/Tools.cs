using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PS3.Models.User;

namespace ASP_PS3.Models.ViewModel.User.Static
{
    public class Tools
    {
        public List<UserDB> SendUserToList(List<UserDB> users, UserFrame user)
        {
            int identifier;

            if (users != null)
            {
                identifier = (users[users.Count - 1].Identifier) + 1;
            }
            else
            {
                users = new List<UserDB>();
                identifier = 1;
            }
            users.Add(new UserDB
            {
                Identifier = identifier,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Age = user.Age,
                Adult = (user.Age < 18) ? false : true
            });
            return users;
        }
        public List<UserDB> ReplaceUserInList(List<UserDB> users, UserFrame user, int id)
        {
            UserDB oryginalUser = users.Find(x => x.Identifier == id);
            oryginalUser.FirstName = user.FirstName;
            oryginalUser.LastName = user.LastName;
            oryginalUser.Age = user.Age;
            oryginalUser.Adult = (user.Age < 18) ? false : true;
            return users;
        }
        public List<UserDB> RemoveUserFromList(List<UserDB> users, int id)
        {
            users.RemoveAt(users.FindIndex(x => x.Identifier == id));
            return users;
        }
        public static UserFrame GetUserFromList(List<UserDB> users, int id)
        {
            UserDB userDB = users.Find(x => x.Identifier == id);
            return new UserDB() {
                Identifier = userDB.Identifier,
                FirstName = userDB.FirstName,
                LastName = userDB.LastName,
                Age = userDB.Age,
                Adult = userDB.Adult
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.DataAccess;
using TravelApp.Model;

namespace TravelApp.DataServices
{
    public class UserDataService : IUserDataService
    {
        Func<TravelDbContext> _contextCreator;

        public UserDataService(Func<TravelDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public void AddUser(User user)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Users.Add(user);
            }
        }

        public bool CheckSignIn(User user)
        {
            using (var ctx = _contextCreator())
            {

                var realuser = ctx.Users.AsNoTracking().Single(f => f.Username == user.Username);
                if (realuser.Password == user.Password)
                    return true;
                return false;
            }
        }
    }
}

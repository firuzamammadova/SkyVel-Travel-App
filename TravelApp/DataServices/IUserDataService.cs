using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;

namespace TravelApp.DataServices
{
    public interface IUserDataService
    {
        bool CheckSignIn(User user);
        void AddUser(User user);
    }
}

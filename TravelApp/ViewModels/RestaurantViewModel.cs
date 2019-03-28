using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.ViewModels
{
    class RestaurantViewModel:IPageViewModel
    {
       public string Name
        {
            get
            {
                return "Restaurant";
            }
        }
    }
}

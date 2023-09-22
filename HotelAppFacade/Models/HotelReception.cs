using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppFacade.Models
{
    public class HotelReception
    {

        public void GetIndianMenu()
        {
            IHotel indianHotel=new IndianHotel();
            IMenu menu=indianHotel.GetMenu();
            menu.DisplayMenu();
           
        }

        public void GetItalianMenu()
        {
            IHotel italianHotel=new ItalianHotel();
            IMenu italianMenu=italianHotel.GetMenu();
            italianMenu.DisplayMenu();
        }

    }
}

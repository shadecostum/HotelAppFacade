using HotelAppFacade.Models;

namespace HotelAppFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            HotelReception hotelReception = new HotelReception();
            hotelReception.GetIndianMenu();
            hotelReception.GetItalianMenu();
           

        }
    }
}
using HotelSearch.HotelServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelSearchClient searchClient = new HotelSearchClient("BasicHttpBinding_IHotelSearch");
            HotelModel[] hotelsList = searchClient.GetAllHotels(); 
            for (int i = 0; i < hotelsList.Length; i++)
            {
                Console.WriteLine("Hotel Id --- " + hotelsList[i].HotelId);
                Console.WriteLine("Hotel Name --- " + hotelsList[i].HotelName);
                Console.WriteLine("Hotel Address--- " + hotelsList[i].HotelAddress);
                Console.WriteLine("Hotel Rating --- " + hotelsList[i].HotelRating);
                Console.WriteLine("Start date --- " + hotelsList[i].StartDate);
                Console.WriteLine("End date --- " + hotelsList[i].EndDate); 
                Console.WriteLine("==============================================");
                Console.WriteLine();
            }

            Console.WriteLine("Enter hotel Id to search details");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            HotelModel hotel = new HotelModel();
            hotel = searchClient.GetHotelById(userChoice);
            if (hotel != null)
            {
                Console.WriteLine("Hotel Id --- " + hotel.HotelId);
                Console.WriteLine("Hotel Name --- " + hotel.HotelName);
                Console.WriteLine("Hotel Address--- " + hotel.HotelAddress);
                Console.WriteLine("Hotel Rating --- " + hotel.HotelRating);
                Console.WriteLine("Start date --- " + hotel.StartDate);
                Console.WriteLine("End date --- " + hotel.EndDate);
            }
            else
                Console.WriteLine("No Hotel found with id {0}", userChoice);
            Console.ReadKey();
        }
    }
}

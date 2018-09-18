using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHotelWCF
{
    public class HotelFunctionalities : IHotelSearch
    {
       
        public List<HotelModel> GetAllHotels()
        {
            List<HotelModel> items = new List<HotelModel>();
            using (StreamReader r = new StreamReader("Hotels.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<HotelModel>>(json);
            }
            return items;
        }

        public HotelModel GetHotelById(int Id)
        {
            List<HotelModel> items = GetAllHotels();
            var hotelModel = items.Find(x => x.HotelId == Id);
            if (hotelModel != null)
                return hotelModel;
            else
                return null;
        }
    }
}

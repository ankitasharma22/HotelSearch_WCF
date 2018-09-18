using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SearchHotelWCF
{
    [ServiceContract]
    public interface IHotelSearch
    {
        [OperationContract]
        List<HotelModel> GetAllHotels();

        [OperationContract]
        HotelModel GetHotelById(int Id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SearchHotelWCF
{
    [DataContract]
    public class HotelModel
    {
        [DataMember]
        public int HotelId;
        [DataMember]
        public string HotelName;
        [DataMember]
        public string HotelAddress;
        [DataMember]
        public int HotelRating;
        [DataMember]
        public DateTime StartDate;
        [DataMember]
        public DateTime EndDate;
    }
}

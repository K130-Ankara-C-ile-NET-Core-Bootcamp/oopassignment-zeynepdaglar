using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarInfo
    { 
        public Guid CarId;
        //globaly unıque ıdentıfier
        //ıdlerin benzersiz olması için Guid kullanılır

        public Coordinates Coordinates;
        public CarInfo(Guid carId, Coordinates coordinates)
        {
            this.CarId = carId;
            this.Coordinates = coordinates;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Surface : ISurface, ICollidableSurface, IObserver<CarInfo>
    {
        private List<CarInfo> carInfo = new List<CarInfo>();
        public long Width { get; private set; }

        public long Height { get; private set; }

        public List<CarInfo> GetObservables()
        {
            return new List<CarInfo>(carInfo);
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates) 
        {
            for (int i = 0; i < carInfo.Count; i++)
            {
                if (coordinates.X == carInfo[i].Coordinates.X && coordinates.Y == carInfo[i].Coordinates.Y )
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates) 
        {
            if (coordinates.Y >= Height || coordinates.X >= Width || coordinates.X < 0 || coordinates.Y <0)
            {
                return false;
            }
            return true;
        }

        public void Update(CarInfo provider)
        {
            foreach (var car in carInfo)
            {
                if (car.CarId == provider.CarId)
                {
                    car.Coordinates = provider.Coordinates;
                    return;
                }
            }
            carInfo.Add(provider);
        }

        public Surface(long width, long height)
        {
            Width = width;
            Height = height;
        }

      
    }
}

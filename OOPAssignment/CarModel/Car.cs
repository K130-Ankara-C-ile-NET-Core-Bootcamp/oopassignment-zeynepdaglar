using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Car : CarInfo, ICarCommand, IObservable<CarInfo>
    {
       
        public Direction Direction;
        public ISurface Surface;

        private IObserver<CarInfo> Observer;

        public Car(Coordinates coordinates, Direction direction, ISurface surface):base(Guid.NewGuid(), coordinates)
        {
            this.Direction = direction;
            this.Surface = surface;
        }

        public void Move()
        {
            var target = new Coordinates(Coordinates.X, Coordinates.Y);
            switch (Direction)
            {
                case Direction.N: target.Y++; 
                    break;
                case Direction.E: target.X++;
                    break;
                case Direction.S: target.Y--;
                    break;
                case Direction.W: target.X--;
                    break;
             
            }

            if (Surface.IsCoordinatesInBounds(target) && Surface.IsCoordinatesEmpty(target))
            {
                Coordinates = target;

            }
            else
            {
                throw new Exception("cordinat is not empty or in bounds");
            }
        }

        public void Notify()
        {
           
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.N: Direction = Direction.W;
                    break;
                case Direction.E: Direction = Direction.S;
                    break;
                case Direction.S: Direction = Direction.E;
                    break;
                case Direction.W: Direction = Direction.N;
                    break;
            }

        }

        public void TurnRight()
        {
          
             switch (Direction)
                {
                    case Direction.N: Direction = Direction.E;
                        break;
                    case Direction.E: Direction = Direction.S;
                        break;
                    case Direction.S: Direction = Direction.W;
                        break;
                    case Direction.W: Direction = Direction.N;
                        break;
                }

            
        }

        public void Attach(IObserver<CarInfo> observer)
        {
            Observer = observer;
            observer.Update(this);
        }

   
    }
}

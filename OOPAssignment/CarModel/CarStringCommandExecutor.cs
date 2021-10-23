using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {

        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {

        }
        
        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrEmpty(commandObject) )
            {
                throw new Exception();
            }
            else if (commandObject != "R" && commandObject != "L" && commandObject != "M")
            {
                throw new Exception();
            }

            switch (commandObject)
            {
                case "R":
                    CarCommand.TurnRight();
                    break;
                case "L":
                    CarCommand.TurnLeft();
                    break;
                case "M":
                    CarCommand.Move();
                    break;
            }          
        }
    }
}

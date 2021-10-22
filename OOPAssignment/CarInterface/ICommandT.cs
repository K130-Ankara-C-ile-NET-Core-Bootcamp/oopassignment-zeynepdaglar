﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public interface ICommand<T>
    {
      void ExecuteCommand(T commandObject);
    }
}

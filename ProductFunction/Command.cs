using System;
using System.Collections.Generic;
using System.Text;

namespace ProductFunction
{
    public class Command
    {
        ICommand _command;
        int _numberOfTimesToCall;
        public Command(
            ICommand command, 
            int numberOfTimesToCall)
        {
            this._command = command;
            this._numberOfTimesToCall = numberOfTimesToCall;
        }

        public void Execute()
        {
            for (var i = 0; i < this._numberOfTimesToCall; i++)
            {
                this._command.Execute();
            }
        }
    }
}

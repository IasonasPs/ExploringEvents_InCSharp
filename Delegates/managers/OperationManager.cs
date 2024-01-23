using Delegates.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.managers
{
    internal class OperationManager
    {
        private int _first;
        private int _second;

        public OperationManager(int first, int second)
        {
            _first = first;
            _second = second;
        }

        private int Sum()
        { return _first + _second; }

        private int Subtract()
        { return _first - _second; }

        private int Multiply()
        { return _first * _second; }

        public int Execute(Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                    return Sum();
                case Operation.Subtract:
                    return Subtract();
                case Operation.Multiply:
                    return Multiply();
                default:
                    return -1;  //
            }
        }
    }
}

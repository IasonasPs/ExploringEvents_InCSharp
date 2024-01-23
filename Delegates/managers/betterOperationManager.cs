using Delegates.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.managers
{
    internal class betterOperationManager
    {
        private int _first;
        private int _second;

        private readonly ExecutionManager _executionManager;

        public betterOperationManager(int first, int second, ExecutionManager executionManager)
        {
            _first = first;
            _second = second;
            _executionManager = executionManager;
            _executionManager.PopulateFunctions(Sum, Subtract, Multiply);
            _executionManager.PrepareExecution();
        }
        #region Operations
        private int Sum()
        {
            return _first + _second;
        }
        private int Subtract()
        {
            return _first - _second;
        }
        private int Multiply()
        {
            return _first * _second;
        }
        #endregion
        public int Execute(Operation operation)
        {
            return _executionManager.FuncExecute.ContainsKey(operation) ?
                                _executionManager.FuncExecute[operation]() : -1;
        }
    }
}



#region Why dont we create the operation methods (i.e : Sum,Subtract,....) before constructor
//Sure, let’s imagine you’re playing a game of chess. You know how to move the pieces - the king, the 
//queen, the rooks, the knights, the bishops, and the pawns. That’s like the Sum, Subtract, and Multip
//ly methods in our code. They are part of the game (or the OperationManager class) and you know how 
//to use them.

//Now, when you start a new game, that’s like creating a new OperationManager.As part of setting up t
//he game, you place your pieces on the board. In the same way, when you create a new OperationManager
//, you’re setting up the ExecutionManager with the moves (methods) it can make.

//So, you don’t need to create the moves (methods) before you start the game (constructor). They are p
//art of the game (class) and are ready to be used as soon as you start playing (create an instance of
// the class). But remember, you can’t make a move until the game has started (the instance is fully c
//onstructed). In our code, we’re not making a move (invoking the methods), but just telling the Execu
//tionManager what moves it can make (passing the method references). And that’s perfectly okay! 😊 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Command6._2.ConcreteCommand;


namespace Command6._2
{
    public class Invoker
    {
        private Coche _coche;
        private Receiver _receiver;
        private OrderCommand _orderCommand;

        public Invoker()
        {
            _receiver = new Receiver();
        }

        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }
        public void SetCoche(Coche coche)
        {
            _coche = coche;
        }

        public void ExecuteCommand()
        {
            _receiver.ExecuteCommand(_orderCommand, _coche);
        }

        public void ShowCurrentOrder()
        {
            _receiver.ShowCurrentCoches();
        }








    }
    public class CommandFactory
    {
        //Factory method
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                case 3:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }
}

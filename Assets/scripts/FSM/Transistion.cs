namespace Core.FSM
{
    public class Transistion : ITransistion
    {
        public IState to { get; }
        public IPredicate Condition { get; }
        public Transistion(IState toState, IPredicate condition)
        {
            to = toState;
            Condition = condition;
        }
    }

}   

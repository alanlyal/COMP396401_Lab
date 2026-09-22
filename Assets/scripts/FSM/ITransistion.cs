
namespace Core.FSM
{
    public interface ITransistion
    {
        IState to {  get; }
        IPredicate Condition { get; }
    }

}   

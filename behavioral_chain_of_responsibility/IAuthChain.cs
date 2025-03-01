namespace chain_of_responsibility
{
    public interface IAuthChain
    {
        IAuthChain SetNextChain(IAuthChain nextChain);
        void Execute(User user);
    }
}
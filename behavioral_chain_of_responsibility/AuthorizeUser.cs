namespace chain_of_responsibility
{
    public class AuthorizeUser : IAuthChain
    {
        private IAuthChain nextChain;

        public IAuthChain SetNextChain(IAuthChain nextChain)
        {
            this.nextChain = nextChain;
            return this.nextChain;
        }

        public void Execute(User user)
        {
            if (user.Username == "admin" && user.Password == "admin")
            {
                System.Console.WriteLine("User is authorized.");
            }
            else
            {
                System.Console.WriteLine("User is not authorized.");
            }
        }
    }
}
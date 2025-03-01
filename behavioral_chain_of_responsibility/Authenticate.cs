namespace chain_of_responsibility
{
    public class Authenticate : IAuthChain
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
                System.Console.WriteLine("User is authenticated.");
            }
            else
            {
                System.Console.WriteLine("User is not authenticated.");
            }

            if (nextChain != null)
            {
                nextChain.Execute(user);
            }
        }
    }
}
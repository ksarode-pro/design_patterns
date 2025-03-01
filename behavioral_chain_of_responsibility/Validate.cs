namespace chain_of_responsibility
{
    public class Validate : IAuthChain
    {
        private IAuthChain _nextChain;

        public IAuthChain SetNextChain(IAuthChain nextChain)
        {
            _nextChain = nextChain;
            return _nextChain;
        }

        public void Execute(User user)
        {
            if (user.Username == null || user.Password == null)
            {
                throw new System.Exception("Username and password are required.");
            }
            else
            {
                System.Console.WriteLine("Username and password are valid.");
            }

            if (_nextChain != null)
            {
                _nextChain.Execute(user);
            }
        }
    }
}
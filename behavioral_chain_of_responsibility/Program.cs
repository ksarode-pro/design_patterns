namespace chain_of_responsibility
// See https://aka.ms/new-console-template for more information
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Username = "admin",
                Password = "admin"
            };

            var val = new Validate();
            var auth = new Authenticate();
            var authorized = new AuthorizeUser();

            val.SetNextChain(auth).SetNextChain(authorized);

            val.Execute(user);
        }
    }
}
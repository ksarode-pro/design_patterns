namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Remote Json Based System: ");
            Console.WriteLine(new RemoteJsonBasedSystem().GetEmployeeList());

            System.Console.WriteLine("Client Xml Based System using adapter: ");
            EmployeeXmlDateAdapter employeeXmlDateAdapter = new EmployeeXmlDateAdapter();
            ClientXmlBasedSystem clientXmlSystem = new ClientXmlBasedSystem(employeeXmlDateAdapter);
            clientXmlSystem.DisplayEmployeeXmlData();
        }
    }
}
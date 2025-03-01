namespace AdapterPattern
{
    // This is Target interface which is used by the Client class (ClientXmlBasedSystem)
    public interface IEmployeeXmlDataTarget
    {
        public string GetEmployeeXmlString();
    }
}
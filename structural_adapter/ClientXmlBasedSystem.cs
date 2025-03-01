using System.Xml;

namespace AdapterPattern
{
    // This is Client class which is using the Target interface (IEmployeeXmlDataTarget)
    public class ClientXmlBasedSystem
    {
        private IEmployeeXmlDataTarget _employeeXmlDataTarget;
        public ClientXmlBasedSystem(IEmployeeXmlDataTarget employeeXmlDataTarget)
        {
            _employeeXmlDataTarget = employeeXmlDataTarget;
        }
        public void DisplayEmployeeXmlData()
        {
            string xmlString = _employeeXmlDataTarget.GetEmployeeXmlString();
            System.Console.WriteLine(xmlString);
        }
    }
}
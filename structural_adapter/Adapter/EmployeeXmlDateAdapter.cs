using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern
{
    // This is Adapter class which implements the Target interface (IEmployeeXmlDataTarget) 
    // and wraps the Adaptee class (RemoteJsonBasedSystem)
    class EmployeeXmlDateAdapter : RemoteJsonBasedSystem, IEmployeeXmlDataTarget
    {
        public string GetEmployeeXmlString()
        {
            string jsonString = GetEmployeeList();

            // Wrap the JSON array inside an object with a property (e.g., "Employees")
            string wrappedJson = "{ \"Employees\": " + jsonString + " }";

            // Convert JSON to XML
            XmlDocument? xml = JsonConvert.DeserializeXmlNode(wrappedJson, "root");

            return xml == null ? "" : xml.OuterXml;
        }
    }
}
using System.Text.Json;

namespace AdapterPattern
{
    // This is Adaptee class which provides the JSON data
    public class RemoteJsonBasedSystem
    {
        public string GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { ID = 101, Name = "John" });
            employeeList.Add(new Employee() { ID = 102, Name = "Smith" });
            employeeList.Add(new Employee() { ID = 103, Name = "Tom" });
            employeeList.Add(new Employee() { ID = 104, Name = "Jerry" });
            return JsonSerializer.Serialize(employeeList);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


// A design pattern that can be used to between two incompatible classes to interact with each other by converting the interface of 
// one class to interface of another class 


namespace AdapterDesignPattern
{
    public class Employee
    {
        public Employee() { }

        public Employee(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public int age { get; set; }
    }

    public class EmployeeController
    {
        public List<Employee> ListEmp;
        public EmployeeController()
        {
            Employee EMP1 = new Employee("Danish", 23);
            Employee EMP2 = new Employee("Radhika",24);
            Employee EMP3 = new Employee("Geeks", 26 );

            ListEmp = new List<Employee>();
            ListEmp.Add(EMP1);
            ListEmp.Add(EMP2);
            ListEmp.Add(EMP3);
            
        }

        public virtual string getEmployeeList()
        {
            var xmlNameSpace = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });

            var serializer = new XmlSerializer(ListEmp.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using(var stream = new StringWriter())
            {
                using(var writer= XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, ListEmp, xmlNameSpace);
                    return stream.ToString();
                }

            }

         }
    }

    public interface IEmployee
    {
         string getEmployeeList();
    }


    public class EmployeeAdapterClass : EmployeeController, IEmployee
    {
        public string list;

        public override string getEmployeeList()
        {
            list = base.getEmployeeList();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(list);
            return JsonConvert.SerializeObject(xmlDocument, Newtonsoft.Json.Formatting.Indented).ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SerializationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FullNAme = "Urinbasarov Dias Nurzhanuly",
                Age = 18
            };

            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //if (!Directory.Exists(@"C:\data"))
            //{
            //    Directory.CreateDirectory(@"C:\data");
            //}
            //using (FileStream stream = File.Create(@"C:\data\file.bin"))
            //{
            //    binaryFormatter.Serialize(stream, person);
            //}

            //using (FileStream stream = File.OpenRead(@"C:\data\file.bin"))
            //{
            //    var result = binaryFormatter.Deserialize(stream) as Person;
            //}

            //SoapFormatter soapFormatter = new SoapFormatter();

            //using (FileStream stream = File.Create(@"C:\data\file.soap"))
            //{
            //    soapFormatter.Serialize(stream, person);
            //}

            //using (FileStream stream = File.OpenRead(@"C:\data\file.soap"))
            //{
            //    var result = soapFormatter.Deserialize(stream) as Person;
            //}

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            //using (FileStream stream = File.Create(@"C:\data\file.xml"))
            //{
            //    xmlSerializer.Serialize(stream, person);
            //}

            //using (FileStream stream = File.OpenRead(@"C:\data\file.xml"))
            //{
            //    var result = xmlSerializer.Deserialize(stream) as Person;
            //}

            List<Person> people = new List<Person>
            {
                new Person
                {
                    FullNAme = "Urinbasarov Dias Nurzhanuly",
                    Age = 19
                },
                 new Person
                {
                    FullNAme = "Urinbasarov Damir Nurzhanuly",
                    Age = 20
                },
                  new Person
                {
                    FullNAme = "Urinbasarov Dimash Nurzhanuly",
                    Age = 21
                },
                   new Person
                {
                    FullNAme = "Urinbasarov Arman Nurzhanuly",
                    Age = 22
                },
            };

            var result = JsonConvert.SerializeObject(people);

            var deserializeResult = JsonConvert.DeserializeObject<Person>(result);
        }
    }
}

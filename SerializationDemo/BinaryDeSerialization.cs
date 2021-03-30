using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationDemo
{
    class BinaryDeSerialization
    {
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"/Example.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }

    //[Serializable]
    //public class Demo
    //{
    //    public string ApplicationName { get; set; } = "Binary Serialize";
    //    public int ApplicationId { get; set; } = 1001;
    //}

}

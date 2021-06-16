using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP
{
    public static class Serializer<T>
    {
        public static void Serialize(string file, List<T> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}
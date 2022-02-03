using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP
{
    /// <summary>
    /// Class that contain serialization method
    /// </summary>
    /// <typeparam name="T"> Type of serialization data </typeparam>
    public static class Serializer<T>
    {
        /// <summary>
        /// Method of serialization
        /// </summary>
        /// <param name="file"> xml file </param>
        /// <param name="list"> list of serializing data </param>
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace FF_At_the_scene_
{
    public static class Utilities
    {
        public static void SerializeXML<T>(string s, T t, string path)
        {
            if (Directory.Exists(path))
            {
                using (FileStream fs = File.Create(path + s + ".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(fs, t);
                    fs.Close();
                }
            }

        }

        /// <summary>
        /// deserialize from a path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <returns></returns>
        public static T DeserializeXML<T>(string s)
        {
            
            T t; //We will use the as the return value      
            
            using (FileStream fs = File.OpenRead(s + ".xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);                
                fs.Close();
            }

            return t;
        }

    }
}
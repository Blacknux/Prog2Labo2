using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase19
{
    public class Xml <T> : IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        { 
            try
            {
                System.Xml.Serialization.XmlSerializer serial = new System.Xml.Serialization.XmlSerializer(typeof(T));

                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    serial.Serialize(writer, datos);
                    writer.Close();
                }
                return true;
                  
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool leer(string archivo,  out T target)
    {
        try
        {
            System.Xml.Serialization.XmlSerializer serial = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                target = (T)serial.Deserialize(reader);
                reader.Close();

            }
            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            target = default(T);
            return false;
        }


    }

    }
}

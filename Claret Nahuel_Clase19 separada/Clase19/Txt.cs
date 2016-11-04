using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    public class Texto  : IArchivo<String>
    {
        public bool guardar(string archivo, string datos)
        { 
            try
            {
                using (System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(archivo,true))
                {
                    fileWriter.WriteLine(datos);
                }
                    return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool leer(string archivo,  out string target)
    {
        try
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(archivo))
            {
                target = reader.ReadToEnd();

            }
            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            target = null;
            return false;
        }


    }

    }
}

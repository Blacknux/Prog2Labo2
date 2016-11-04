using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    public interface IArchivo <T>
    {
         bool guardar(string archivo, T Datos);
         bool leer(string archivo, out T Datos);
    }
}

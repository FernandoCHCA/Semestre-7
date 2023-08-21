using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura.Models
{
    internal class Animal
    {
        public string Nombre { get; set; }

        public virtual string GetNombre()
        {
            return Nombre;
        }
    }
}

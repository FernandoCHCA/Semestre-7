using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Models
{
    internal class Animal
    {
        protected string Nombre { get; set; }

        public virtual string GetNombre()
        {
            return Nombre;
        }
    }
}

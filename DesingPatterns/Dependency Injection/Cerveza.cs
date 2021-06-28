using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Dependency_Injection
{
    public class Cerveza
    {
        private string _nombre;
        private string _marca;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public Cerveza(string nombre, string marca)
        {
            _nombre = nombre;
            _marca = marca;
        }

    }
}

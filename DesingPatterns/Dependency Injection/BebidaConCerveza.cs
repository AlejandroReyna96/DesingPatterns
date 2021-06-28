using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Dependency_Injection
{
    public class BebidaConCerveza
    {
        // Esto está mal, esta clase no debe  tener la responsabilidad de saber como se cosntruye el objeto de la otra Clase Cerveza
        // Los objetos hijos no debe saber como crearlos
        // Que tal si en un futuro tengo otro parámetro, entonces lo voy a cambiar en todos lados, es mucho tabajar
        // private Cerveza _cerveza = new Cerveza("Indio", "Heineken");

        private Cerveza _cerveza;
        private decimal _agua;
        private decimal _azucar;

        public BebidaConCerveza(decimal agua, decimal azucar, Cerveza cerveza)
        {
            _agua = agua;
            _azucar = azucar;
            _cerveza = cerveza;
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparando bebida que tiene agua {_agua} y de azucar {_azucar} y cerveza {_cerveza.Nombre}");
        }
    }
}

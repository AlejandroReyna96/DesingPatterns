using DesingPatterns.Dependency_Injection;
using DesingPatterns.Factory_Method;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            var log = Singleton.Log.Instance;
            log.Save("a");
            log.Save("b");

            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;

            Console.WriteLine(a == b);

            // -----------------------------------


            // Factory Method
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(5);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);


            // -------------------------------------

            // Dependency Injection 
            var cerveza = new Cerveza("Indio", "Heineken");
            var bebidaConCerveza = new BebidaConCerveza(10, 2, cerveza);
            bebidaConCerveza.Preparar();

            // bebidaConCerveza depende de Cerveza, pero ya no tiene la responsabilidad de saber la construcción
        }
    }
}

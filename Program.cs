using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "testando o nome aqui";

            Console.WriteLine(nome.Cortar(5));

            DateTime dt = new DateTime(2022, 01, 01, 8, 10, 40);

            Console.WriteLine(dt.DataCortada());
            
        }
    }
}

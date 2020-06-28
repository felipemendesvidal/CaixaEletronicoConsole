using System;

namespace conta_no_console
{
    class Program
    {
        static void Main(string[] args)
        {


            Conta juares = new Conta();
            Console.WriteLine(juares.abrirConta("corrente"));
        }
    }
}

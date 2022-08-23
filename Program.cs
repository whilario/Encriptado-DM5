using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            encrypmd5 en = new encrypmd5();

            Console.Write("Ingrese mensaje para cifrar: ");
            string mensaje = Console.ReadLine();
            string endara = en.encrypt(mensaje);
            Console.WriteLine("mensaje encriptado: " + endara);

            Console.WriteLine("mensaje desencriptado: " + en.decryp(endara));
            Console.ReadKey();

        }  

    }
}

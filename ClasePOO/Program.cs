using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    class Program
    {


        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.nombre = "coopel";
            int n;
            do
            {
                Console.WriteLine("Que operacion desea realliar");
                Console.WriteLine("[1] depositar");
                Console.WriteLine("[2] mostrar informacion");
                Console.WriteLine("[3] salir");
                n = int.Parse(Console.ReadLine());
                int c;
                switch (n)
                {
                    case 1:
                        float dep;
                        Console.WriteLine("ingrese numero de  cliente");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca la cantida a depositar");
                        dep = float.Parse(Console.ReadLine());
                        banco.Depositar(dep, c);
                        break;

                    case 2:
                        Console.WriteLine("ingrese el numero del cliente ");
                        c = int.Parse(Console.ReadLine());
                        banco.Imprimir(c);

                        break;


                }

            } while (n != 3);
        }


    }
}
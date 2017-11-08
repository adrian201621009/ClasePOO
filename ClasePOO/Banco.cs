using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePOO
{
    public class Banco
    {
        public string nombre { get; set; }
        Cliente[] clientes;
        public Banco()
        {
            clientes = new Cliente[]
            {
                new Cliente(){ Nombre = "CARLOS", Edad = 20, Saldo = 0 },
                new Cliente(){ Nombre = "MARIA", Edad = 29, Saldo = 0 },
                new Cliente(){ Nombre = "PEDRO", Edad = 25, Saldo = 0 },
                new Cliente(){ Nombre = "Daniel", Edad = 41, Saldo = 0 },
                new Cliente(){ Nombre = "SAUL", Edad = 22, Saldo = 0 }

            };
        }

        public void Depositar(float deposito, int nCliente)
        {
            clientes[nCliente].Saldo += deposito;
        }
        public void Imprimir(int cliente)
        {
            Console.WriteLine($"{clientes[cliente].Nombre}tiene de saldo: {clientes[cliente].Saldo}");
        }

    }
}
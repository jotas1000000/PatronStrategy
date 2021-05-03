using System;
using System.Collections.Generic;
using System.Text;

namespace TecnologiasSonidoEnvolventeVirtual
{
    class WindowsSonic : ISonidoEnvolventeVirtualStrategy
    {
        public void SonandoBocinasVirtuales(string musica)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Activando Tecnologia Windows Sonic");
            Console.WriteLine("Simulando sonido 7.1 y configurando paralantes estereo");
            Console.WriteLine($"Sonando {musica}");
            Console.WriteLine("--------------------------------");
        }
    }
}

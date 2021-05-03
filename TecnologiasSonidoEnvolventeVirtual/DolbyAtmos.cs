using System;
using System.Collections.Generic;
using System.Text;

namespace TecnologiasSonidoEnvolventeVirtual
{
    class DolbyAtmos : ISonidoEnvolventeVirtualStrategy
    {
        public void SonandoBocinasVirtuales(string musica)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Activando Tecnologia Dolby Atmos");
            Console.WriteLine("Transformando los sonidos a objetos y enviando a bocinas");
            Console.WriteLine($"Sonando {musica}");
            Console.WriteLine("--------------------------------");

        }
    }
}

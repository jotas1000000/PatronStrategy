using System;
using System.Collections.Generic;
using System.Text;

namespace TecnologiasSonidoEnvolventeVirtual
{
    class DTS_X : ISonidoEnvolventeVirtualStrategy
    {
        public void SonandoBocinasVirtuales(string musica)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Activando Tecnologia DTS:X");
            Console.WriteLine("Transformando los sonidos a objetos, efectos 3D y enviando a bocinas");
            Console.WriteLine($"Sonando {musica}");
            Console.WriteLine("--------------------------------");
        }
    }
}

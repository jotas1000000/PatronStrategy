using System;
using System.Collections.Generic;
using System.Text;

namespace TecnologiasSonidoEnvolventeVirtual
{
    class Reproductor
    {
        ISonidoEnvolventeVirtualStrategy tecnologiaEnvolvente=null;

        public Reproductor()
        {
            
        }

        public void reproducir(string musica)
        {
            if (tecnologiaEnvolvente != null)
            {
                tecnologiaEnvolvente.SonandoBocinasVirtuales(musica);

            }else
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Reproduciendo en Stereo normal");
                Console.WriteLine($"Sonando {musica}");
                Console.WriteLine("--------------------------------");
            }
        }

        public void setTecnologiaVirtual(ISonidoEnvolventeVirtualStrategy tecnologiaEnvolvente)
        {
            this.tecnologiaEnvolvente = tecnologiaEnvolvente;
        }
    }
}

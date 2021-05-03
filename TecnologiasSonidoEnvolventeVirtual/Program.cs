using System;

namespace TecnologiasSonidoEnvolventeVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            string musica = "Love Won't Let Me Down - Hillsong";

            ISonidoEnvolventeVirtualStrategy dolby = new DolbyAtmos();
            ISonidoEnvolventeVirtualStrategy dts = new DTS_X();
            ISonidoEnvolventeVirtualStrategy windowsSonic = new WindowsSonic();

            Reproductor VLC = new Reproductor();
            VLC.reproducir(musica);

            VLC.setTecnologiaVirtual(dolby);
            VLC.reproducir(musica);

            VLC.setTecnologiaVirtual(dts);
            VLC.reproducir(musica);

            VLC.setTecnologiaVirtual(windowsSonic);
            VLC.reproducir(musica);


        }
    }
}

using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo("hyunday", "sonata", "1412", " preto", 40, 50 ,true, 60) ;
            v.exibirdados();
            v.ligar();
            v.acelerar();
            v.abastecer(50); 

           

           



        }
    }
}

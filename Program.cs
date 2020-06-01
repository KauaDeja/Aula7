using System;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 10;
            master.ComprarComDescontoMastercard(80f);

        }
    }
}

using System;

namespace Abstracao_POO.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void Pagar(float valor){
            if(valor <= saldo){
                Console.WriteLine("Pagamento efetuado com sucesso!");
            }else{
                Console.WriteLine("Saldo Insuficiente!");
            }
            return;
        }
    }
}
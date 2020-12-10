using System;

namespace Abstracao_POO.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public void Registrar(){
            Console.WriteLine("Boleto Registrado e Enviado por e-mail !");
        }

       
    }
}
using System;

namespace Abstracao_POO.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return "";
        }
        
    }
}
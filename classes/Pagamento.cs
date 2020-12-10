using System;

namespace Abstracao_POO.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{
            get{return DateTime.Now;}
        }



        protected float valor;
        public float Valor{
            set{valor = value;}
            get{return valor;}
        }

        public string Cancelar(){
            return "";
        }
        
    }
}
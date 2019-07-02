using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Telefone : Contato
    {

        // atributo numero
        private int numero;

        public int Numero
        {

            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }

        }

        // construtor da classe
        public Telefone(int numero)
        {
            this.numero = numero;
        }

        public List<string> Comunicar()
        {
            return new List<String>() {
                "Ligar para " + this.numero
            };
        }

    }
}

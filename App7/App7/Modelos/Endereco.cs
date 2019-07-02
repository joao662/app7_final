using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Endereco : Contato
    {

        // atributo rua
        private String rua;

        public String Rua
        {

            get
            {
                return this.rua;
            }

            set
            {
                this.rua = value;
            }

        }

        // atributo cidade
        private String cidade;

        public String Cidade
        {

            get
            {
                return this.cidade;
            }

            set
            {
                this.cidade = value;
            }

        }

        // construtor da classe
        public Endereco(String rua, String cidade)
        {
            this.rua = rua;
            this.cidade = cidade;
        }

        public List<string> Comunicar()
        {
            return new List<String>() {
                "Enviar correio para " + this.rua + " de " + this.cidade
            };
        }
    }
}

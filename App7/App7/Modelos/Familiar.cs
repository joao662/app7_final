using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Familiar : Pessoa, Contato
    {

        // atributo tipo
        private String tipo;

        public String Tipo
        {

            get
            {
                return this.tipo;
            }

            set
            {
                this.tipo = value;
            }

        }

        // construtor da classe
        public Familiar(String nome, int cpf) : base(nome, cpf)
        {
        }

        // construtor da classe
        public Familiar(String nome, int cpf, String tipo) : base(nome, cpf)
        {
            this.tipo = tipo;
        }

        public List<string> Comunicar()
        {
            // criar uma lista interna
            List<String> lista = new List<String>();
            // percorre todos os contatos
            foreach (Contato contato in this.Contatos)
            {
                // adiciona o resultado de Comunicar do contato a lista interna
                lista.AddRange(contato.Comunicar());
            }
            // retorna lista
            return lista;
        }

    }

}

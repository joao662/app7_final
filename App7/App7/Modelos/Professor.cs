using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Professor : Pessoa
    {
        // atributo codigo
        private int codigo;

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        // construtor da classe
        public Professor(String nome, int cpf, int codigo) : base(nome, cpf)
        {
            this.codigo = codigo;
        }

    }

}

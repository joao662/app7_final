using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Aluno : Pessoa
    {

        // lista de matriculas
        public List<Matricula> Matriculas = new List<Matricula>();

        
        // construtor da classe
        public Aluno(String nome, int cpf) : base(nome, cpf)
        {
        }

        // método cursar (estabelece uma dependência da classe com Matricula e Curso)
        public Matricula Cursar(Curso curso)
        {
            // criar nova matrícula
            Matricula matricula = new Matricula(this, curso);
            // adicionar na lista
            Matriculas.Add(matricula);
            // retornar nova matrícula
            return matricula;
        }


    }
}

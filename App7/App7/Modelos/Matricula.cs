using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Matricula
    {

        // lista de históricos
        public List<Historico> Historicos = new List<Historico>();

        // atributo aluno
        private Aluno aluno;

        public Aluno Aluno
        {
            get
            {
                return this.aluno;
            }
            set
            {
                this.aluno = value;
            }
        }

        // atributo curso
        private Curso curso;

        public Curso Curso
        {
            get
            {
                return this.curso;
            }
            set
            {
                this.curso = value;
            }
        }

        // atributo ano
        private int ano;

        public int Ano
        {
            get
            {
                return this.ano;
            }
            set
            {
                if (value >= 0)
                {
                    this.ano = value;
                }
            }
        }

        // atributo semestre
        private int semestre;

        public int Semestre
        {
            get
            {
                return this.semestre;
            }
            set
            {
                if (value >= 1 && value <= 2)
                {
                    this.semestre = value;
                }
            }
        }

        // atributo codigo
        private String codigo;

        public String Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        // construtor da classe
        public Matricula()
        {
        }

        // construtor da classe
        public Matricula(Aluno aluno, Curso curso)
        {
            this.aluno = aluno;
            this.curso = curso;
            // pegar data atual
            DateTime date = DateTime.Now;
            this.ano = date.Year;
            this.semestre = date.Month % 6;
            this.codigo = date.Millisecond.ToString();
        }

        // método matricular (estabelece uma dependência da classe com Histórico e Turma)
        public Historico Matricular(Turma turma)
        {
            // criar novo histórico
            Historico historico = new Historico(this, turma);
            // adicionar na lista
            Historicos.Add(historico);
            // retornar novo histórico
            return historico;
        }

    }
}

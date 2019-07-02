using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    class Historico
    {

        // lista de notas (estabelece uma agregação com a classe Nota)
        public List<Nota> Notas = new List<Nota>();

        // atributo matricula
        private Matricula matricula;

        public Matricula Matricula
        {
            get
            {
                return this.matricula;
            }
            set
            {
                this.matricula = value;
            }
        }

        // atributo turma
        private Turma turma;

        public Turma Turma
        {
            get
            {
                return this.turma;
            }
            set
            {
                this.turma = value;
            }
        }

        // atributo faltas
        private int faltas;

        public int Faltas
        {
            get
            {
                return this.faltas;
            }
            set
            {
                if (value >= 0)
                {
                    this.faltas = value;
                }
            }
        }

        // classe interna (estabelece uma composição entre Histórico e Resultado) 
        public class Resultado
        {

            // atributo media
            private float media;

            public float Media
            {
                get
                {
                    return this.media;
                }
            }

            // atributo aprovado
            private bool aprovado;

            public bool Aprovado
            {
                get
                {
                    return this.aprovado;
                }
            }

            // construtor da classe
            public Resultado(float media, bool aprovado)
            {
                this.media = media;
                this.aprovado = aprovado;
            }

        }

        // método para calcular resultado
        public Resultado Calcular()
        {
            // variável para calcular média
            float media = 0;
            // percorre todas as notas
            foreach (Nota nota in this.Notas)
            {
                media += nota.Valor;
            }
            // calcular a média
            media = media / this.Notas.Count;
            // variável para verificar se o aluno foi aprovado
            bool aprovado = (media >= 5) && (this.faltas <= 0.75 * this.turma.Disciplina.Horas);
            // retornar o resultado
            return new Resultado(media, aprovado);
        }

        // construtor da classe
        public Historico()
        {
        }

        // construtor da classe
        public Historico(Matricula matricula, Turma turma)
        {
            this.matricula = matricula;
            this.turma = turma;
        }

    }

}

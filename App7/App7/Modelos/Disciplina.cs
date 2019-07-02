using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    public class Disciplina
    {

        // lista de cursos
        public List<Curso> cursos = new List<Curso>();
       

        // atributo requisito
        public Disciplina requisito { get; set; }

        public String nome { get; set; }
        public int horas { get; set; }
        public Disciplina Requisito { get; set; }

        public Disciplina(String nome)
        {
            this.nome = nome;
        }

    }
}

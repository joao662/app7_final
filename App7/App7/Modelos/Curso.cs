using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Modelos
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Disciplina> disciplinas = new List<Disciplina>();

        public Curso(String Nome)
        {
            this.Nome = Nome;
        }

    }
}

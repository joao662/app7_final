using App7.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NvCursoPG : ContentPage
    {
        
        public NvCursoPG()
        {
            InitializeComponent();
            
        }
        private void Cadastra_lista_curso(object sender, EventArgs e)
        {
            Curso curso = new Curso(NomeCurso.Text);
            Listas.Cursos.Add(curso);

        }

    }
}
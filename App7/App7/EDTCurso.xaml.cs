using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App7.Modelos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EDTCurso : ContentPage
    {
        public EDTCurso()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Cursos.Items.Clear();

            foreach (Curso curso in Listas.Cursos)
            {
                Cursos.Items.Add(curso.Nome);
            }
        }
        public void SalvarEDT(object sender,EventArgs e)
        {
            Listas.Cursos.RemoveAt(Cursos.SelectedIndex);
            Cursos.Items.Clear();
            Curso curso = new Curso(NovoCurso.Text);
            Listas.Cursos.Add(curso);
            foreach (Curso Curso in Listas.Cursos)
            {
                Cursos.Items.Add(Curso.Nome);
            }
            DisplayAlert("Operação", "Curso editado!", "Ok");
        }
        public void ExcluirCurso(object sender, EventArgs e)
        {
            Listas.Cursos.RemoveAt(Cursos.SelectedIndex);
            Cursos.Items.Clear();
            foreach (Curso curso in Listas.Cursos)
            {
                Cursos.Items.Add(curso.Nome);
            }
            DisplayAlert("Operação", "Curso removido!", "Ok");
        }
    }
}
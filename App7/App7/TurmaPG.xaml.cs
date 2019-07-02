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
    public partial class TurmaPG : ContentPage
    {
        public TurmaPG()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            discplinas.Items.Clear();
            turmas.Items.Clear();
            professores.Items.Clear();

            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                discplinas.Items.Add(disciplina.nome + " - " + disciplina.cursos + " - " + disciplina.Requisito + " - " + disciplina.horas);
            }
            foreach (Turma turma in Listas.Turmas)
            {
                turmas.Items.Add(turma.Disciplina + " - " + turma.Semestre + " - " + turma.Ano);
            }
            foreach (Professor professor in Listas.Professores)
            {
                professores.Items.Add(professor.Nome + " - " + professor.Codigo);
            }
        }
        private async void Novaturma(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Novaturmapg());
        }
        public void Turmaedt(object sender, EventArgs e)
        {

        }
               private async void ASCprofessor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new associarprof());

        }

    }
}
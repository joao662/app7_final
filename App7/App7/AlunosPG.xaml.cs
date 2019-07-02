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
    public partial class AlunosPG : ContentPage
    {
        public AlunosPG()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Alunos.Items.Clear();
            MatrAluno.Items.Clear();
            Contatos.Items.Clear();

            foreach (Aluno aluno in Listas.Alunos)
            {
                Alunos.Items.Add(aluno.Nome + " - " + aluno.Cpf);
            }
            foreach (Matricula matricula in Listas.Matriculas)
            {
                MatrAluno.Items.Add(matricula.Aluno.Nome + " - " + matricula.Curso.Nome);
            }
            foreach (Aluno aluno in Listas.Alunos)
            {
                Contatos.Items.Add(aluno.Nome);
            }
        }
            private async void NovoAluno(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoAluno());
        }

        public void EDTAluno(object sender, EventArgs e)
        {

        }
        public void MTRCURSO(object sender, EventArgs e)
        {

        }
    }
}
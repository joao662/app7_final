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
    public partial class Novaturmapg : ContentPage
    {
        public Novaturmapg()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Disciplinas.Items.Clear();
            professores.Items.Clear();

            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Disciplinas.Items.Add(disciplina.nome + " - " + disciplina.horas);
            }
            foreach (Professor professor in Listas.Professores)
            {
                professores.Items.Add(professor.Nome + " - " + professor.Codigo);
            }
        }


        void SalvarTurma(object sender, EventArgs args)
        {
            if (Disciplinas.Items.Count > 0 && Ano.Text != null && professores.Items.Count > 0 && Semestre.Text != null)
            {
                Turma turma = new Turma(Listas.Disciplinas.ElementAt(Disciplinas.SelectedIndex), Listas.Professores.ElementAt(professores.SelectedIndex));
                turma.Ano = Convert.ToInt32(Ano.Text);
                turma.Semestre = Convert.ToInt32(Semestre.Text);
                Listas.Turmas.Add(turma);
                DisplayAlert("Sucess!", "Turma Cadastrada com Sucesso", "Ok");
            }
            else
            {
                DisplayAlert("Fail", "Não foi possivel cadastrar a turma", "Ok");
            }

        }
    }
}
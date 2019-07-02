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
	public partial class EDTurma : ContentPage
	{
		public EDTurma ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker0.Items.Clear();
            Picker.Items.Clear();
            Picker2.Items.Clear();

            foreach (Turma turma in Listas.Turmas)
            {
                Picker0.Items.Add(turma.Disciplina + " - " + turma.Semestre + " - " + turma.Ano);
            }
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Picker.Items.Add(disciplina.nome + " - " + disciplina.cursos + " - " + disciplina.Requisito + " - " + disciplina.horas);
            }
            foreach (Professor professor in Listas.Professores)
            {
                Picker2.Items.Add(professor.Nome + " - " + professor.Codigo);
            }
        }



        void ButtonSalvar(object sender, EventArgs args)
        {
            if (Picker.Items.Count > 0 && Entry.Text != null && Picker2.Items.Count > 0 && Entry2.Text != null && Picker0.Items.Count > 0)
            {
                Listas.Turmas.RemoveAt(Picker0.SelectedIndex);
                Turma turma = new Turma(Listas.Disciplinas.ElementAt(Picker.SelectedIndex), Listas.Professores.ElementAt(Picker2.SelectedIndex));
                turma.Ano = Convert.ToInt32(Entry.Text);
                turma.Semestre = Convert.ToInt32(Entry2.Text);
                Listas.Turmas.Add(turma);
            }

        }
    }
}
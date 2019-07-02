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
	public partial class EDTdisciplina : ContentPage
	{
		public EDTdisciplina ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerListaDisciplinasExistentes.Items.Clear();
            PickerPreRequisito.Items.Clear();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito != null)
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.nome + " - " + disciplina.horas + "h " + " - " + "Pré requisito: " + disciplina.Requisito.nome);
                }
                else
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.nome + " - " + disciplina.horas + "h");
                }
            }
            foreach (Disciplina disciplina2 in Listas.Disciplinas)
            {
                PickerPreRequisito.Items.Add(disciplina2.nome);
            }
        }

        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {
            Listas.Disciplinas.RemoveAt(PickerListaDisciplinasExistentes.SelectedIndex);
            Disciplina disciplina = new Disciplina(NomeDisciplinas.Text);
            disciplina.horas = Convert.ToInt32(disciplina.horas);
            if (PickerPreRequisito.SelectedIndex >= 0)
            {
                disciplina.Requisito = Listas.Disciplinas.ElementAt(PickerPreRequisito.SelectedIndex);
            }

            PickerListaDisciplinasExistentes.Items.Clear();
            PickerPreRequisito.Items.Clear();
            Listas.Disciplinas.Add(disciplina);
            foreach (Disciplina Disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito != null)
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.nome + " - " + disciplina.horas + "horas. " + "Pré-requisito:" + disciplina.Requisito.nome);
                }
                else
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.nome + " - " + disciplina.horas + "horas.");
                }
                PickerPreRequisito.Items.Add(Disciplina.nome);
            }
            DisplayAlert("Operação", "Disciplina editada!", "Ok");
            NomeDisciplinas.Text = " ";
            EntryHoras.Text = " ";
        }

        private void ButtonExcluir_Clicked(object sender, EventArgs e)
        {
            Listas.Disciplinas.RemoveAt(PickerListaDisciplinasExistentes.SelectedIndex);
            PickerListaDisciplinasExistentes.Items.Clear();
            foreach (Disciplina Disciplina in Listas.Disciplinas)
            {
                PickerListaDisciplinasExistentes.Items.Add(Disciplina.nome + "-" + Disciplina.horas + "h");
            }
            DisplayAlert("Operação", "Disciplina excluida!", "Ok");
        }
    }
}
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
	public partial class LancarFaltas : ContentPage
	{
		public LancarFaltas ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();

            foreach (Matricula matricula in Listas.Matriculas)
            {
                Picker.Items.Add(matricula.Aluno.Nome + " - " + matricula.Codigo);
            }
        }

        void PickerSelecionado(object sender, EventArgs args)
        {
            Picker1.Items.Clear();
            Matricula matricula = Listas.Matriculas.ElementAt(Picker.SelectedIndex);
            foreach (Historico historico in matricula.Historicos)
            {
                Picker1.Items.Add(historico.Turma.Disciplina.nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker.SelectedIndex >= 0 && Picker1.SelectedIndex >= 0 && Entry.Text != null)
            {
                Historico historico = Listas.Matriculas.ElementAt(Picker.SelectedIndex).Historicos.ElementAt(Picker1.SelectedIndex);
                historico.Faltas = int.Parse(Entry.Text);

                Navigation.PushModalAsync(new HistoricosPG());
            }
            else { }
        }
    }
}
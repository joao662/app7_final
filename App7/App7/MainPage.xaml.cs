using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void CursosPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CursosPagina());
        }
        private async void DisciplinasPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisciplinaPG());
        }
        private async void AlunosPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlunosPG());
        }
        private async void ProfessoresPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfessoresPG());
        }
        private async void TurmasPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TurmaPG());
        }
        private async void MatriculasPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MatriculasPG());
        }
        private async void HistoricosPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoricosPG());
        }
        private async void ContatosPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContatosPG());
        }

    }
}

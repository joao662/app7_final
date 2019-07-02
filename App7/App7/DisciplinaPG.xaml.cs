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
    public partial class DisciplinaPG : ContentPage
    {
        public DisciplinaPG()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Disciplinas.Items.Clear();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito == null)
                {
                    Disciplinas.Items.Add(disciplina.nome + "-" + disciplina.horas + "h");

                }
                else
                {
                    Disciplinas.Items.Add(disciplina.nome + "-" + disciplina.horas + "h" + "pré requisito :" + disciplina.Requisito.nome);
                }

            }
        }
        private async void NovaDp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Novadp());
        }
        public void EDTDiscplina(object sende, EventArgs e)
        {

        }
        private async void ASCcurso(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ASCcurso());
        }
    }
}
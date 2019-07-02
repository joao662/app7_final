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
    public partial class ProfessoresPG : ContentPage
    {
        public ProfessoresPG()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            professores.Items.Clear();
            foreach (Professor professor in Listas.Professores)
            {
                professores.Items.Add(professor.Nome + " - " + professor.Cpf + " - " + professor.Codigo);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovoProfessor());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EDTProfessor());
        }
        public void professornovo(object sender,EventArgs e)
        {

        }
        public void professoreditar(object sender, EventArgs e)
        {

        }
    }
}
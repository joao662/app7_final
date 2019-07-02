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
    public partial class Novadp : ContentPage
    {
        public Novadp()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisciplinasPRQ.Items.Clear();
            foreach ( Disciplina diciplina in Listas.Disciplinas)
            {
                DisciplinasPRQ.Items.Add(diciplina.nome + " - " + diciplina.horas);
            }
        }
        public void SalvarPrqdp(object sender,EventArgs e)
        {
            Disciplina disciplina = new Disciplina(Nome.Text);
            disciplina.horas = Convert.ToInt32(Horas.Text);
            if (DisciplinasPRQ.SelectedIndex >= 0)
            {
                disciplina.Requisito = Listas.Disciplinas.ElementAt(DisciplinasPRQ.SelectedIndex);
            }
            Listas.Disciplinas.Add(disciplina);

            DisciplinasPRQ.Items.Clear();
            foreach (Disciplina Disciplina in Listas.Disciplinas)
            {
                DisciplinasPRQ.Items.Add(Disciplina.nome);
            }

            DisplayAlert("Cadastro", "Disciplina cadastrada", "Ok");
            Nome.Text = " ";
            Horas.Text = " ";
        }
    }
}
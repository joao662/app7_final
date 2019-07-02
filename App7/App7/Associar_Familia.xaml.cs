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
	public partial class Associar_Familia : ContentPage
    {
        public Associar_Familia()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();

            foreach (Pessoa pessoa in Listas.Pessoas)
            {
                Picker.Items.Add(pessoa.Nome);
            }

        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);

            Familiar contato = new Familiar(Entry.Text, int.Parse(Entry1.Text), Entry2.Text);

            pessoa.Contatos.Add(contato);

            Listas.Pessoas.Add(contato);


            Navigation.PushModalAsync(new ContatosPG());

        }
    }
}
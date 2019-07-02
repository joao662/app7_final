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
	public partial class Associar_Endereço : ContentPage
	{
		public Associar_Endereço ()
		{
			InitializeComponent ();
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

            Endereco endereco = new Endereco(Entry.Text, Entry1.Text);

            pessoa.Contatos.Add(endereco);

            Navigation.PushModalAsync(new ContatosPG());

        }
    }
}
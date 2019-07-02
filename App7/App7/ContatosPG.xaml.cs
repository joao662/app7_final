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
    public partial class ContatosPG : ContentPage
    {
        public ContatosPG()
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

        void PickerSelecionado(object sender, EventArgs args)
        {
            Picker1.Items.Clear();
            Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);

            foreach (Contato contato in pessoa.Contatos)
            {
                foreach (string exibir in contato.Comunicar())
                {
                    Picker1.Items.Add(exibir);
                }

            }
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Associar_Familia());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Associar_Endereço());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Associar_Internet());
        }

        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Associar_Telefone());
        }

        void OnButtonClicked4(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());

        }

        void OnButtonClicked5(object sender, EventArgs args)
        {
            //Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);
            //pessoa.Contatos.RemoveAt(Picker1.SelectedIndex);
            Navigation.PushModalAsync(new MainPage());
        }

        void OnButtonClicked6(object sender, EventArgs args)
        {
            if (Picker.SelectedIndex > -1)
            {
                Listas.Pessoas.RemoveAt(Picker.SelectedIndex);
                Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}
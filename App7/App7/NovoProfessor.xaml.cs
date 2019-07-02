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
	public partial class NovoProfessor : ContentPage
	{
		public NovoProfessor ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Entry1.Text != null && Entry2.Text != null && Entry3.Text != null)
            {
                Professor professor = new Professor(Entry1.Text, Convert.ToInt32(Entry2.Text), Convert.ToInt32(Entry3.Text));
                Listas.Professores.Add(professor);
                Listas.Pessoas.Add(professor);
                DisplayAlert("App7", "Professor salvo com sucesso.", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Há campos sem preencher.", "OK");
            }
        }
    }
}
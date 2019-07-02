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
	public partial class EDTAluno : ContentPage
	{
		public EDTAluno()
        {
            InitializeComponent();

            foreach (Aluno aluno in Listas.Alunos)
            {
                Picker1.Items.Add(aluno.Nome + " - " + aluno.Cpf);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker1.Items.Count > 0 && Entry1.Text != null && Entry2.Text != null)
            {
                Listas.Alunos.RemoveAt(Picker1.SelectedIndex);
                Aluno aluno = new Aluno(Entry1.Text, Convert.ToInt32(Entry2.Text));
                Listas.Alunos.Add(aluno);

                Listas.Pessoas.RemoveAt(Picker1.SelectedIndex);
                Pessoa pessoa = new Aluno(Entry1.Text, Convert.ToInt32(Entry2.Text));
                Listas.Pessoas.Add(pessoa);

                DisplayAlert("App7", "Modificação realizada com sucesso.", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Há campos sem preencher.", "OK");
            }

        }
    }
}
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
    public partial class NovoAluno : ContentPage
    {
        public NovoAluno()
        {
            InitializeComponent();
        }
        void Salvarinfo(object sender, EventArgs args)
        {
            if (NomeAluno.Text != null && CpfAluno.Text != null)
            {
                Aluno aluno = new Aluno(NomeAluno.Text, Convert.ToInt32(CpfAluno.Text));


                Listas.Alunos.Add(aluno);
                Listas.Pessoas.Add(aluno);
                DisplayAlert("App7", "Aluno salvo com sucesso.", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Há campos sem preencher.", "OK");
            }
        }
    }
}
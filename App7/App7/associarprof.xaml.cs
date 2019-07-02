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
    public partial class associarprof : ContentPage
    {
        public associarprof()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            turmas.Items.Clear();
            professores.Items.Clear();

            foreach (Turma turma in Listas.Turmas)
            {
                turmas.Items.Add(turma.Ano + " - " + turma.Semestre + " - " + turma.Disciplina + " - " + turma.Professores);
            }

            foreach (Professor professor in Listas.Professores)
            {
                professores.Items.Add(professor.Nome + " - " + professor.Codigo);
            }

        }
        public void Associarprofturma(object sender,EventArgs e)
        {

        }
        public void removerProfturma(object sender, EventArgs e)
        {

        }
        public void remover(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class lancarnotas : ContentPage
    {
        public lancarnotas()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            turmas.Items.Clear();

            foreach (Matricula matricula in Listas.Matriculas)
            {
                turmas.Items.Add(matricula.Aluno.Nome + " - " + matricula.Codigo);
            }
        }

        void PickerSelecionado(object sender, EventArgs args)
        {
            professores.Items.Clear();
            Matricula matricula = Listas.Matriculas.ElementAt(turmas.SelectedIndex);
            foreach (Historico historico in matricula.Historicos)
            {
                professores.Items.Add(historico.Turma.Disciplina.nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (turmas.SelectedIndex >= 0 && professores.SelectedIndex >= 0 && Entry.Text != null && Entry1.Text != null)
            {
                Historico historico = Listas.Matriculas.ElementAt(turmas.SelectedIndex).Historicos.ElementAt(professores.SelectedIndex);
                historico.Notas.Add(new Nota()
                {
                    Valor = float.Parse(Entry.Text),
                    Data = DateTime.Parse(Entry1.Text)
                });


                Navigation.PushModalAsync(new HistoricosPG());
            }
            else { }
        }
        public void Lançarnotadta(object sender,EventArgs e)
        {

        }
    }
}
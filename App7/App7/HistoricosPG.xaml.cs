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
    public partial class HistoricosPG : ContentPage
    {
        public HistoricosPG()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Matriculas.Items.Clear();

            foreach (Matricula matricula in Listas.Matriculas)
            {
                Matriculas.Items.Add(matricula.Aluno.Nome + " - " + matricula.Codigo);
            }
        }

        void PickerSelecionado(object sender, EventArgs args)
        {
            Historicos.Items.Clear();
            Matricula matricula = Listas.Matriculas.ElementAt(Matriculas.SelectedIndex);
            foreach (Historico historico in matricula.Historicos)
            {
                Historicos.Items.Add(historico.Turma.Disciplina.nome);
            }
        }


        void PickerSelecionado1(object sender, EventArgs args)
        {
            Historico historico = Listas.Matriculas.ElementAt(Matriculas.SelectedIndex).Historicos.ElementAt(Historicos.SelectedIndex);
            Historico.Resultado resultado = historico.Calcular();

            Notas.Items.Clear();
            foreach (Nota nota in historico.Notas)
            {

                Notas.Items.Add(nota.Valor.ToString());

            }

            if (resultado.Aprovado)
            {

                Label1.Text = " Resultado: Aprovado";

            }
            else
            {

                Label1.Text = "Resultado: Reprovado";

            }


            Label2.Text = "Faltas:" + historico.Faltas;

            Labe3.Text = "Media:" + resultado.Media;


        }
        private async void Lançarotas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lancarnotas());
        }
        public void RemoverNotas(object sender, EventArgs e)
        {

        }
        public void Lançarfaltas(object sender, EventArgs e)
        {

        }
    }
}
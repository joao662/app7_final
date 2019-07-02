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
    public partial class ASCcurso : ContentPage
    {
        public ASCcurso()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Cursos.Items.Clear();
            Disciplinas.Items.Clear();
            foreach (Curso curso in Listas.Cursos)
            {
                Cursos.Items.Add(curso.Nome);
            }
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Cursos.Items.Add(disciplina.nome);
            }
        }
        public void AssociarCurso(object sender, EventArgs e)
        {
            Disciplina d = Listas.Disciplinas.ElementAt(Disciplinas.SelectedIndex);
            Curso c = Listas.Cursos.ElementAt(Cursos.SelectedIndex);
            d.cursos.Add(c);
            c.disciplinas.Add(d);

            Disciplina d5 = c.disciplinas.ElementAt(Cursos.SelectedIndex);

            DisplayAlert("Status", d5.nome, "Ok");

            //d.Cursos.Insert(PickerListDisciplina.SelectedIndex, Listas.Cursos.ElementAt(PickerListCursos.SelectedIndex));
            //c.Disciplinas.Insert(PickerListCursos.SelectedIndex, Listas.Disciplinas.ElementAt(PickerListDisciplina.SelectedIndex));
            DisplayAlert("Status", "Associação feita!", "Ok");
        }
        public void RemoverCurso(object sender, EventArgs e)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fab
{
    public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            Lista.ItemsSource = CarregarLista();
        }

        public async void Button_OnClicked(object sender, EventArgs e)
        {
            await this.DisplayAlert("Atenção", "Floating button funcionando", "OK");
        }

        private List<ModeloDeInformacao> CarregarLista()
        {
            return new List<ModeloDeInformacao>()
            {
                new ModeloDeInformacao(){Titulo="Teste 1",Descricao="Este é o teste 1"},
                new ModeloDeInformacao(){Titulo="Teste 2",Descricao="Este é o teste 2"},
                new ModeloDeInformacao(){Titulo="Teste 3",Descricao="Este é o teste 3"},
                new ModeloDeInformacao(){Titulo="Teste 4",Descricao="Este é o teste 4"},
                new ModeloDeInformacao(){Titulo="Teste 5",Descricao="Este é o teste 5"},
                new ModeloDeInformacao(){Titulo="Teste 6",Descricao="Este é o teste 6"},
                new ModeloDeInformacao(){Titulo="Teste 7",Descricao="Este é o teste 7"},
                new ModeloDeInformacao(){Titulo="Teste 8",Descricao="Este é o teste 8"},
                new ModeloDeInformacao(){Titulo="Teste 9",Descricao="Este é o teste 9"},
                new ModeloDeInformacao(){Titulo="Teste 10",Descricao="Este é o teste 10"},
            };
        }
    }
}

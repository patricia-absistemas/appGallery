using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.PaginaDeNavegacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Conteudo03 : ContentPage
	{
		public Conteudo03 ()
		{
			InitializeComponent ();
		}

        private void VoltarParaPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void VoltarParaInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync(); //Volta para pagina e limpa o histórico
        }

        private void RemoverPaginaPilha(object sender, EventArgs e)
        {
            Navigation.RemovePage(
                Navigation.NavigationStack[0]);
        }

        private void InserirPaginaPilha(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(
                new PaginaInserida(),
                Navigation.NavigationStack[0]);
            //Qual pagina quer inserir, pagina que vai ser inserida antes
        }
    }
}
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
    public partial class PaginaInserida : ContentPage
    {
        public PaginaInserida()
        {
            InitializeComponent();
        }

        private void AbrirPaginaInicial(object sender, EventArgs e)
        {
            //Deixar pagina aberta da forma q entra no projeto
            App.Current.MainPage = new NavigationPage(
                new Conteudo01()
            );
        }
    }
}
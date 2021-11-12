using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarimForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarimForms.Paginas.PaginaDeConteudo.Conteudo01());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarousselPage(object sender, EventArgs e)
        {
            
                ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarimForms.Paginas.PaginaDeCarrossel.Carrossel());
                ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

          
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {

            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarimForms.Paginas.PaginaDeAbas.Abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarimForms.Paginas.Modal.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarimForms.Leiautes.PilhaLeiaute.Pilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarimForms.Leiautes.GridLeiaute.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}
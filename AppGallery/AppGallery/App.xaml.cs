using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Instanciando a var pagina
            /*
             * 
             * 
             * 
             var pagina = new XamarimForms.Paginas.Modal.Conteudo01();
             
            var pagina = new CarouselPage(); //Carroussel page tem vários filhos
            pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrossel.Conteudo02());
            pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrossel.Conteudo03());

            pagina.CurrentPage = pagina.Children[1]; */
            MainPage = new XamarimForms.Paginas.PaginaDeCarrossel.Carrossel();
          
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

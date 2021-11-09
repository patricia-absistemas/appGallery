using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.PaginaDeCarrossel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : CarouselPage
    {
        public Carrossel()
        {
            InitializeComponent();

            CurrentPage = Children[1]; //É a mesma instrução do botao
        }
    }
}
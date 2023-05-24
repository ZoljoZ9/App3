using App3.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List : ContentPage
    {
        private readonly VegetableViewModel _viewModel;

        public List()
        {
            InitializeComponent();
            _viewModel = new VegetableViewModel();
            BindingContext = _viewModel;
        }
    }
}

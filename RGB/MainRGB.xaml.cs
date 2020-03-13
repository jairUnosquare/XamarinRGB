using RGB.ViewModel;
using Xamarin.Forms;

namespace RGB
{
    public partial class MainRGB : ContentPage
    {
        MainRGBViewModel _viewModel;

        public MainRGB()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainRGBViewModel();
        }
    }
}

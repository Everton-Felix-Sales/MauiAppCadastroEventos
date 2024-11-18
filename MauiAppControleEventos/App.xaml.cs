using MauiAppControleEventos.Models;
using MauiAppControleEventos.Views;

namespace MauiAppControleEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContratacaoEvento());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 725;

            return window;
        }
    }
}

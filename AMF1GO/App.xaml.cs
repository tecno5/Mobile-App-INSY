using Microsoft.Maui.Controls;

namespace AMF1GO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Use a NavigationPage for the main page
            MainPage = new NavigationPage(new MainPage());
        }
    }
}

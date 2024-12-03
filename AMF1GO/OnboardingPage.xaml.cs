using Microsoft.Maui.Controls;

namespace AMF1GO
{
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileCreationPage());
        }

        private async void SkipButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileCreationPage());
        }
    }
}

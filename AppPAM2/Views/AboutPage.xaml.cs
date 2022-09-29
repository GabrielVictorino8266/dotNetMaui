namespace AppPAM2.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
        /*
		 * if (BindingContext is Models.About about)
		{ 
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }
		*/
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}
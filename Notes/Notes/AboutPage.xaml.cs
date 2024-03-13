namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
	private async void LeranMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://google.com");
	}
}
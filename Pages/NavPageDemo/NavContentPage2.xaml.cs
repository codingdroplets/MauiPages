namespace MauiPages.Pages.NavPageDemo;

public partial class NavContentPage2 : ContentPage
{
	public NavContentPage2()
	{
		InitializeComponent();
	}

	private async void navContentPage3Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NavContentPage3());
	}

	private async void closeButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
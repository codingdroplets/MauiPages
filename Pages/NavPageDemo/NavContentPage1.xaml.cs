namespace MauiPages.Pages.NavPageDemo;

public partial class NavContentPage1 : ContentPage
{
	public NavContentPage1()
	{
		InitializeComponent();
	}

	private async void navContentPage2Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NavContentPage2());
	}
}
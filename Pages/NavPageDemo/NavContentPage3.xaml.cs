namespace MauiPages.Pages.NavPageDemo;

public partial class NavContentPage3 : ContentPage
{
	public NavContentPage3()
	{
		InitializeComponent();
	}

	private async void closeButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
namespace MauiPages.Pages.ContentPagesDemo;

public partial class DemoContentPage3 : ContentPage
{
	public DemoContentPage3()
	{
		InitializeComponent();
	}

	private async void closeButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}
namespace MauiPages.Pages.ContentPagesDemo;

public partial class DemoContentPage2 : ContentPage
{
	public DemoContentPage2()
	{
		InitializeComponent();
	}

	private async void closeButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}

	private async void contentPage3Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new DemoContentPage3());
	}
}
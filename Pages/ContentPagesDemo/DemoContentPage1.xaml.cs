namespace MauiPages.Pages.ContentPagesDemo;

public partial class DemoContentPage1 : ContentPage
{
	public DemoContentPage1()
	{
		InitializeComponent();
	}

	private async void contentPage2Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new DemoContentPage2());
	}
}
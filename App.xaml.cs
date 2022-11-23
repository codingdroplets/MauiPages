using MauiPages.Pages.ContentPagesDemo;
using MauiPages.Pages.FlyoutPageDemo;
using MauiPages.Pages.NavPageDemo;
using MauiPages.Pages.TabbedPageDemo;

namespace MauiPages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new DemoContentPage1();

        //var navigationPage = new NavigationPage(new NavContentPage1());
        //navigationPage.BarBackgroundColor = Colors.Firebrick;
        //navigationPage.BarTextColor = Colors.Black;
        //MainPage = navigationPage;

        //MainPage = new DemoFlyoutPage();

        MainPage = new DemoTabbedPage();
    }
}

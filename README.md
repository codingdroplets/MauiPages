# .NET MAUI Pages

Watch Tutorial Video: https://www.youtube.com/watch?v=G_vktKfMU20

This is video is part of a series named .NET MAUI Tutorial.
.NET MAUI Tutorial Series:

https://www.youtube.com/playlist?list=PLzewa6pjbr3KKuUTp8ivXjcR4rvFvyoNw

In this video, we'll discuss about different types of pages [.NET MAUI Page Types] that we can use in .NET MAUI.
Also we'll see how to navigate between different pages in .NET MAUI [DotNet MAUI Navigation].

.NET MAUI Page Types [.NET MAUI pages]:-
1. MAUI Content Page

The .NET Multi-platform App UI (.NET MAUI) ContentPage displays a single view, which is often a layout such as as Grid or StackLayout, and is the most common page type.

ContentPage defines a Content property, of type View, which defines the view that represents the page's content. This property is backed by a BindableProperty object, which means that it can be the target of data bindings, and styled. In addition, ContentPage inherits Title, IconImageSource, BackgroundImageSource, IsBusy, and Padding bindable properties from the Page class.

.NET MAUI apps typically contain multiple pages that derive from ContentPage, and navigation between these pages can be performed.

The child of a ContentPage is typically a layout, such as Grid or StackLayout, with the layout typically containing multiple views. However, the child of the ContentPage can be a view that displays a collection, such as CollectionView.

2. MAUI Navigation Page

The .NET Multi-platform App UI (.NET MAUI) NavigationPage provides a hierarchical navigation experience where you're able to navigate through pages, forwards and backwards, as desired. NavigationPage provides navigation as a last-in, first-out (LIFO) stack of Page objects.

.NET MAUI supports modeless page navigation. A modeless page stays on screen and remains available until you navigate to another page.
A NavigationPage is typically used to navigate through a stack of ContentPage objects. When one page navigates to another, the new page is pushed on the stack and becomes the active page.
When the second page returns back to the first page, a page is popped from the stack, and the new topmost page then becomes active.
A NavigationPage consists of a navigation bar, with the active page being displayed below the navigation bar.
We also included some of the customizations available in MAUI Navigation Bar.

3. MAUI Flyout Page

The .NET Multi-platform App UI (.NET MAUI) FlyoutPage is a page that manages two related pages of information – a flyout page that presents items, and a detail page that presents details about items on the flyout page. Selecting an item on the flyout page will navigate to the corresponding detail page.
To create a flyout page, create a FlyoutPage object and set it's Flyout and Detail properties. The Flyout property should be set to ContentPage object, and the Detail property should be set to a TabbedPage, NavigationPage, or ContentPage object. This will help to ensure a consistent user experience across all platforms.

4. MAUI Tabbed Page

The .NET Multi-platform App UI (.NET MAUI) TabbedPage maintains a collection of children of type Page, only one of which is fully visible at a time. Each child is identified by a series of tabs across the top or bottom of the page. Typically, each child will be a ContentPage and when its tab is selected the page content is displayed.
In a TabbedPage, each Page object is created when the TabbedPage is constructed. This can lead to a poor user experience, particularly if the TabbedPage is the root page of your app. However, .NET MAUI Shell enables pages accessed through a tab bar to be created on demand, in response to navigation.

MAUI Page Navigation:

A page can be navigated to by calling the PushAsync method on the Navigation property of the current page.

The active page can be popped from the navigation stack by pressing the Back button on a device, regardless of whether this is a physical button on the device or an on-screen button. To programmatically return to the previous page, the PopAsync method should be called on the Navigation property of the current page.

.NET MAUI supports modal page navigation. A modal page encourages users to complete a self-contained task that cannot be navigated away from until the task is completed or cancelled.

A page can be modally navigated to by calling the PushModalAsync method on the Navigation property of the current page. To programmatically return to the original page, the PopModalAsync method should be called on the Navigation property of the current page.

#dotnetmaui #netmaui #visualstudio2022 #maui #codingdroplet #dotnet6

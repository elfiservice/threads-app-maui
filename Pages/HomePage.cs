namespace ThreadsApp.Pages;

public class HomePage : ContentPage
{
	public HomePage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to Home page!"
				}
			}
		};
	}
}
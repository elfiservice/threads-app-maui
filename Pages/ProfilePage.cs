namespace ThreadsApp.Pages;

public class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Profile page"
				}
			}
		};
	}
}
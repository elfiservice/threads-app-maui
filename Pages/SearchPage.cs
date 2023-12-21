namespace ThreadsApp.Pages;

public class SearchPage : BasePage
{
	public SearchPage()
	{
        Shell.SetSearchHandler(this, new SearchHandler
        {
            Placeholder = "Search",
            ShowsResults = false,
            CancelButtonColor = Colors.Black,
            Keyboard = Keyboard.Text
        });
	}

    public override void Build()
    {
        Title = "Search";

        var listView = new ListView(ListViewCachingStrategy.RecycleElement);
        listView.HasUnevenRows = true;
        listView.SelectionMode = ListViewSelectionMode.None;
        // listView.ItemsSource = ThreadsGenerator.CreateUsers();
        // listView.ItemTemplate = new DataTemplate(typeof(UserViewCell));

        Content = listView;
    }
}
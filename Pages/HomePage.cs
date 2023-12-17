namespace ThreadsApp.Pages;

using ThreadsApp.Controls;
using ThreadsApp.Helpers;

// https://github.com/elfiservice/ThreadsApp-study/commit/0d9821a8eeb4f8b796e345cd2665ad643ea574ab
public partial class HomePage : BasePage
{
	public HomePage()
	{
	}

    public override void Build()
    {
        var listView = new ListView(ListViewCachingStrategy.RetainElement)
		{
			HasUnevenRows = true,
			ItemTemplate = new DataTemplate(typeof(ThreadCell)),
			IsPullToRefreshEnabled = true,

			ItemsSource = ThreadsGenerator.CreateThreads()
		};

		Content = listView;
    }
}
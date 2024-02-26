namespace ThreadsApp.Pages;

using ThreadsApp.Controls;
using ThreadsApp.UseCases;

// https://github.com/elfiservice/ThreadsApp-study/commit/0d9821a8eeb4f8b796e345cd2665ad643ea574ab
public partial class HomePage : BasePage
{
    private readonly IViewThreadsUseCase viewThreadsUseCase;

    public HomePage(IViewThreadsUseCase viewThreadsUseCase)
	{
		this.viewThreadsUseCase = viewThreadsUseCase;

	}

    public override void Build()
    {
        var listView = new ListView(ListViewCachingStrategy.RetainElement)
		{
			HasUnevenRows = true,
			ItemTemplate = new DataTemplate(typeof(ThreadCell)),
			IsPullToRefreshEnabled = true,

			ItemsSource = this.viewThreadsUseCase.ExecuteAsync().Result
		};

		Content = listView;
    }
}
namespace ThreadsApp.Pages;
using ThreadsApp.Helpers;
using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;
using ThreadsApp.Controls;
using ThreadsApp.Models;

// https://github.com/elfiservice/ThreadsApp-study/commit/0d9821a8eeb4f8b796e345cd2665ad643ea574ab
public partial class HomePage : ContentPage
{
	public HomePage()
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

	public class ThreadCell : ViewCell
	{
		const int iconSize = 20;

		public ThreadCell()
		{
            View = new Grid
			{
				Padding = 10,
				ColumnDefinitions = Columns.Define(Auto, Star, Auto, Auto),
				ColumnSpacing = 10,
				RowSpacing = 5,
				RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto),
				Children =
				{

					new Image()
					.Bind(Image.SourceProperty, nameof(AThread.Image))
					.Width(35).Height(35)
					.Row(0).Column(0)
					.RowSpan(2)
					.CenterHorizontal()
					.Top()
					.Margin(new Thickness(0, 5, 0, 0))
					.Aspect(Aspect.AspectFill),
					new HorizontalStackLayoutSpaced(5)
					{
						new Label()
							.Bind(Label.TextProperty, nameof(AThread.User))
							.Bold()
							.Bottom(),
						new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.CircleCheck)
							.TextColor(Colors.Blue)
							.Bind(Label.IsVisibleProperty, nameof(AThread.IsVerified))
							.Bottom()
					}.Row(0).Column(1),
					new Label()
						.Bind(Label.TextProperty, nameof(AThread.TimeAgo))
						.Row(0).Column(2)
						.Bottom(),
					new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.Ellipsis)
						.Row(0).Column(3)
						.Bottom(),
					new Label()
						.Bind(Label.TextProperty, nameof(AThread.Message))
						.Row(1).Column(1)
						.ColumnSpan(3),
					new HorizontalStackLayoutSpaced()
					{
						new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.Heart)
							.FontSize(iconSize),
						new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.Comment)
							.FontSize(iconSize),
						new FontAwesomeLabel(FontAwesomeStyle.Solid, FontAwesomeIcons.Retweet)
							.FontSize(iconSize),
						new FontAwesomeLabel(FontAwesomeStyle.Regular, FontAwesomeIcons.PaperPlane)
							.FontSize(iconSize)
					}.Row(2).Column(1),
					new HorizontalStackLayoutSpaced
					{
						new Label()
							.Bind(Label.TextProperty, nameof(AThread.Replies), stringFormat: "{0} replies")
							.Bind(Label.IsVisibleProperty, nameof(AThread.HasReplies))
							.CenterVertical(),
						new Label()
							.Bind(Label.TextProperty, nameof(AThread.Likes), stringFormat: "{0} likes")
							.Bind(Label.IsVisibleProperty, nameof(AThread.HasLikes))
							.CenterVertical(),
					}.Row(3).Column(1).ColumnSpan(3),


				}
			};
		}
	}

}
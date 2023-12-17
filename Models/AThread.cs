namespace ThreadsApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;

	public partial class AThread : ObservableObject
	{
		[ObservableProperty]
		string user;
		[ObservableProperty]
		string image;
		[ObservableProperty]
		string message;
		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(HasLikes))]
		int likes;
		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(HasReplies))]
		int replies;
		[ObservableProperty]
		bool isVerified;
		[ObservableProperty]
		string timeAgo;

		public bool HasReplies => Replies > 0;
		public bool HasLikes => Likes > 0;
	}

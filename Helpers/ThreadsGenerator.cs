﻿using System.Collections;
using ThreadsApp.Models;

namespace ThreadsApp.Helpers;

public static class ThreadsGenerator
{
    public static IEnumerable CreateThreads() {
        return new[]
			{
				new AThread
				{
					User = "jamesmontemagno",
					Image = "profilecircle.png",
					Message = "This is a thread message that you should read",
					IsVerified = false, Likes = 10, Replies = 2, TimeAgo = "2h"
				},
				new AThread
				{
					User = "dotnet.developers",
					Image = "profilecircle.png",
					Message = "Hi, I am .NET Bot! I am here to help you with your .NET related questions. I will respond to commands that start with a dot (\".\"). To see what I can do type .help. I will only respond once per thread.",
					IsVerified = true, Likes = 10, Replies = 2, TimeAgo = "2h"
				},
			};
    
    }
}